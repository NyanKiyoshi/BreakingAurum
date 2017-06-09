<!DOCTYPE html>
<html>
    <head>
        <title></title>
    </head>
    
    <body>
    <?php
        function error_reporting_handler($data)
        {
            $TICKET_FILE = './data/tickets_data.txt';
            $TICKET_NUMBER = uniqid();
            $TIMESTAMP = time();

            // replaces the new lines by <br />
            $data = str_replace(array("\r\n", "\r", "\n"), "<br />", $data);

            file_put_contents($TICKET_FILE, "$TICKET_NUMBER|$TIMESTAMP|$data\n", FILE_APPEND | LOCK_EX);
            return $TICKET_NUMBER;
        }


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
            $API_TOKEN = "a415ab5cc17c8c093c015ccdb7e552aee7911aaa4";
            $EMAIL = "test@test.test";
            $PASSWORD = "test";
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

                // check if it is an error report or not
                if (isset($_POST["is_reporting_error"]) && $_POST["is_reporting_error"] == "true") {
                    // decode the base64 data and sanitize it
                    $decoded_data = htmlspecialchars(base64_decode($message));
                    $ticket_no = error_reporting_handler($decoded_data);

                    // only send the first 200 chars of the decoded message
                    $message = mb_strimwidth($decoded_data, 0, 200);

                    // answer with a ticket number
                    header('X-SERVER-ANSWER: Ticket number: ' . $ticket_no);
                }

                // send the SMS
                $sms_gateway->sendMessageToManyNumbers($phone_numbers, $message, $DEVICE_ID);
            }
        }
    ?>
    </body>
</html>
