USE esport_team_hub;

CREATE TABLE IF NOT EXISTS player (
user_id INT,
platform ENUM("PC, PlayStation, Xbox"),
FOREIGN KEY (user_id) REFERENCES user(user_id) 
ON DELETE CASCADE
ON UPDATE CASCADE
);