Feature: Logger

Logger scenarios


Scenario: Login log
Given the User tries do log in the Application
When the login is successfully
Then the Application writes the timestamp
And log message "[INFO] User logged in"

Scenario: Failed to write log
Given the User tries do log in the Application
When the Application fail to write the log
Then the Application shows the console message "Error writing to log file"

Scenario: Failed login log
Given the User tries do log in the Application
When the login is fail
Then the Application writes the timestamp
And log message "[WARNING] Failed login attempt"