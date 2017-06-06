<!DOCTYPE html>
<html>
    <head>
        <title></title>
    </head>
    
    <body>
    <?php

        if ($_SERVER['REQUEST_METHOD'] === 'GET') {
             ?>

            <form method="POST" action="" enctype="application/x-www-form-urlencoded">
                <p>
                    <label>
                        Phone number
                        <input type="text" name="number" value="+33615951164" />
                    </label>
                </p>

                <p>
                    <label>
                        API Token
                        <input type="text" name="api_token" />
                    </label>
                </p>

                <p>
                    <label>
                        Message
                        <input type="text" name="message" />
                    </label>
                </p>

                <p>
                    <input type="submit" />
                </p>
            </form>

            <?php
        } elseif ($_SERVER['REQUEST_METHOD'] === 'POST') {
            # code...
            $API_TOKEN = "a415ab5cc17c8c093c015ccdb7e552aee7911aa4";
            $EMAIL = "wibberry@gmail.com";
            $PASSWORD = "1azer1997";
            $DEVICE_ID = 49546;

            if (!isset($_POST["number"], $_POST["message"], $_POST["api_token"])) {
                http_response_code(400);
                echo "400";
            }
            elseif ($_POST["api_token"] != $API_TOKEN) {
                http_response_code(401);
                echo "401";
            }
            else {
                include "smsGateway.php";
                $sms_gateway = new SmsGateway($EMAIL, $PASSWORD);

                $phone_numbers = $_POST["number"];
                $message = $_POST["message"];

                file_put_contents("logged_errors.txt", "\n\n<h3 onclick='toggle(this)'>" . 
                                                        date('l jS \of F Y h:i:s A') . 
                                                        "</h3><div class='hide'><p>To:" . implode(",", $_POST["number"]) . "</p>\n<pre>" . 
                                                            htmlspecialchars(base64_decode($message)) . 
                                                        "</pre>\n</div>",
                                    FILE_APPEND | LOCK_EX); 

                /**$result = $sms_gateway->sendMessageToManyNumbers($phone_numbers, $message, $DEVICE_ID); 

                //echo $_SERVER['QUERY_STRING'];
                echo implode("|", $_POST["number"]);

                echo "<br/>";

                echo "<pre>";
                print_r($result);
                echo "</pre>";**/
            }
        }
    ?>
    </body>
</html>
