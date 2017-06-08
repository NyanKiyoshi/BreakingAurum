<!DOCTYPE html>
<html>
<head>
	<title>Logs</title>
	<meta charset="utf-8"/>
	<style type="text/css">
	@font-face{
		font-family: 'Open Sans';
		font-style: normal;
		font-weight: 400;
		src: local('Open Sans'), local('OpenSans'),
			 url(http://themes.googleusercontent.com/static/fonts/opensans/v6/cJZKeOuBrn4kERxqtaUH3T8E0i7KZn-EPnyo3HZu7kw.woff) format('woff');
	}

	html, body, div, span, applet, object, iframe,
	h1, h2, h3, h4, h5, h6, p, blockquote, pre,
	a, abbr, acronym, address, big, cite, code,
	del, dfn, em, img, ins, kbd, q, s, samp,
	small, strike, strong, sub, sup, tt, var,
	b, u, i, center,
	dl, dt, dd, ol, ul, li,
	fieldset, form, label, legend,
	table, caption, tbody, tfoot, thead, tr, th, td,
	article, aside, canvas, details, embed, 
	figure, figcaption, footer, header, hgroup, 
	menu, nav, output, ruby, section, summary,
	time, mark, audio, video {
		margin: 0;
		padding: 0;
		border: 0;
		font-size: 100%;
		font: inherit;
		vertical-align: baseline;
	}
	/* HTML5 display-role reset for older browsers */
	article, aside, details, figcaption, figure, 
	footer, header, hgroup, menu, nav, section {
		display: block;
	}
	body {
		line-height: 1;
	    font-family: "Open Sans", "Helvetica Neue", Helvetica, Arial, sans-serif;
		max-width: 1048px;
		margin: 0 auto !important;
	    font-size: 1.2rem;
	    line-height: 1.5;
	    color: #606c71;
	}
		.hide {
			display: none;
		}
	ol, ul {
		list-style: none;
	}
	blockquote, q {
		quotes: none;
	}
	blockquote:before, blockquote:after,
	q:before, q:after {
		content: '';
		content: none;
	}
	table {
		border-collapse: collapse;
		border-spacing: 0;
	}

	td, th  { padding: .5em .9375em; }
	thead   { opacity: 0.6 }
	tfoot   { font-size: 11px; opacity: 0.4; text-align: center }
	body 	{ background: #FFF; font: 14px/120% "Lucida Grande", Verdana, sans-serif; }
	div#r 	{ max-width: 1080px; margin: 0 auto; }
	table 	{ width: 100%; border-collapse: collapse; border: 1px solid #69c; }
	/*table tr:nth-child(even) { background: #e9e9e9; }
	table td:first-child {padding-right: 0 }*/
	th 		{ text-align: left; }
	/*tbody   {background: #e8edff}*/
	a 		{ color: #333; text-decoration: none; }
	a:hover { color: #121214; font-weight: 600 }
	small 	{ text-align: center; display: block; }
	tbody tr:hover{ background: rgba(0, 0, 0, 0.07) !important; }

	input {
	    border: 1px solid #69c;
	    padding: 7px;
	    background: #fff;
	    color: #000;
	    border-radius: 3px;
	    margin-left: 7px;
	    line-height: 1em;
	}

	pre {
		font-family: monospace;
		word-wrap: break-word;
		word-break: break-all;
	    white-space: pre-wrap;
	}

	h1 {
		font-size: 2rem;
		font-weight: 800;
		text-align: center;
		margin: 40px;
	}
	h2 {
		font-size: 1.3em;
		font-weight: 800;
		margin-bottom: 1em;
	}

	.entry {
		display: block;
	    font-size: 1.5em;
	    line-height: 1.65;
	    padding: 5px;
	    border-bottom: solid 1px #d4d5d6;
	    clear: both;
	    cursor: pointer;
	    clear: both;
	    margin-bottom: 15px;
	}

	span.info {
	    padding: 5px;
	    border-radius: 10px;
	    color: #fff;
	    font-size: small;
	}

	.date {
	    background: #61a6d7;
	}

	.ticket-no {
	    background: #be474d;
	}

	.big.icon {
	    display: block;
	    float: right;
	}

	.icon:after {
	    content: "+ ";
	}

	.is-open .icon:after {
	    content: "- ";
	}
	</style>

	<script type="text/javascript">
	var current_active_entry;
	function toggle (o) {
		if (current_active_entry != null && current_active_entry != o) {
			current_active_entry.nextSibling.classList.add('hide');
			current_active_entry.classList.remove('is-open');
		}
		current_active_entry = o;
		o.nextSibling.classList.toggle('hide');
		o.classList.toggle('is-open');
	}
	</script>
</head>
<body>
<h1>Reported errors</h1>
<?php

	/**
	 * directory insides as cute listing
	 */
	function endswith($str, $sub) {
   		return (substr($str, strlen($str) - strlen($sub)) === $sub);
	}


    function saveSuccess($ip) {
        $tfp='successes.php';

		if (!is_file($tfp)) {
		    file_put_contents($tfp,"<?php\n\$GLOBALS['success']=array();\n?>", LOCK_EX);
		    chmod($tfp,0705);
		}
	
	    require $tfp;
	    $tres=$GLOBALS['success'];

        $tres[$ip]=time();
        file_put_contents($tfp, "<?php\n\$GLOBALS['success']=".var_export($tres,true).";\n?>", LOCK_EX);
    }


	function hasValidSuccess($ip) {
		$tfp='successes.php';

		if (!is_file($tfp)) {
			return false;
		}

		require $tfp;
		$tres=$GLOBALS['success'];

		//  if no entry       OR  is old of one hour
		if (empty($tres[$ip]) || ($tres[$ip]+3600<time())) {
			return false;
		}

		return true;
	}


	function returnPasswordForm() {
		?>
			<form method="post" style="text-align: center">
				<h2 align="center">Please enter your password for access</h2>
				<input name="password" type="password" size="25" maxlength="100" />
				<input value="go" type="submit">
			</form>
			</body>
			</html>
		<?php
		exit;
	}


	$me 	= __FILE__;
	$dir	= dirname($me);
	$files 	= scandir($dir);
	$req 	= htmlentities ($_SERVER['REQUEST_URI']);

if (!hasValidSuccess($_SERVER['REMOTE_ADDR'])) {
	if (isset($_POST["password"])) {
		$ip=$_SERVER['REMOTE_ADDR'];
		$tfilename='trafic_limiter.php';
		
		if (!is_file($tfilename)) {
			file_put_contents($tfilename,"<?php\n\$GLOBALS['trafic_limiter']=array();\n?>", LOCK_EX);
			chmod($tfilename,0705);
		}

		require $tfilename;
		$tl=$GLOBALS['trafic_limiter'];

		if (!empty($tl[$ip]) && ($tl[$ip]+5>=time())) 		{
			{ 
				echo "Slowdown cowboy!";
				header("HTTP/1.0 403 Forbidden");
				returnPasswordForm();
			}
		}

		if ($_POST["password"]!="hello") {
			header("HTTP/1.0 403 Forbidden");
			$tl[$ip]=time();
			file_put_contents($tfilename, "<?php\n\$GLOBALS['trafic_limiter']=".var_export($tl,true).";\n?>", LOCK_EX);

			returnPasswordForm();
		} else {
			saveSuccess($ip);
		}
	} else {
		returnPasswordForm();
	}
}


?>
	<?php
    $TICKET_FILE = './data/tickets_data.txt';
	$fp=fopen($TICKET_FILE,"r");

	while (($line = fgets($fp)) !== false) {
		$data = explode("|", $line);

		if (count($data) < 3) {
			continue;
		}
		?>

		<div class="entry" onclick="toggle(this)">
			<span class="info date"><?php echo gmdate("d-n-Y @ H:i", $data[1]); ?></span>
			<span class="info ticket-no">#<?php echo $data[0]; ?></span>
			<span class="big icon"></span>
		</div><div class="hide">
			<pre><?php echo $data[2]; ?></pre></div>

		<?php
	}
	$data = file_get_contents("logged_errors.txt");

	?>
</body>
</html>
