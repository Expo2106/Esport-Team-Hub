USE esport_team_hub;

DROP Table user_role;
CREATE TABLE IF NOT EXISTS user_role (
user_id INT,
role ENUM('Leader', 'Manager', 'Player', 'Coach'),
role_added_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
status ENUM('Active', 'Inactive'),
last_updated_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
FOREIGN KEY (user_id) REFERENCES user(user_id) 
ON DELETE CASCADE
ON UPDATE CASCADE
);