<!DOCTYPE html>
<html>
<head>
	<title>Logs</title>
	<meta charset="utf-8"/>
	<style type="text/css">
	.hide {
		display: none;
	}
	</style>

	<script type="text/javascript">
	function toggle (o) {
		o.nextSibling.classList.toggle('hide');
	}
	</script>
</head>
<body>
	<?php echo file_get_contents("logged_errors.txt"); ?>
</body>
</html>
