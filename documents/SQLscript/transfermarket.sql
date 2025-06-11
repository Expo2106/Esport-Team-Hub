USE esport_team_hub;

CREATE TABLE IF NOT EXISTS transfermarket (
listing_id INT AUTO_INCREMENT PRIMARY KEY,
user_id INT NOT NULL,
offering_team_id INT,
requested_value DECIMAL(12,2),
status ENUM ('Listed', 'Pending', 'Accepted', 'Rejected', 'Completed', 'Withdrawn') NOT NULL,
listing_date TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
description TEXT,
FOREIGN KEY (user_id) REFERENCES user(user_id)
ON DELETE CASCADE
ON UPDATE CASCADE,
FOREIGN KEY (offering_team_id) REFERENCES team(team_id)
ON DELETE CASCADE
ON UPDATE CASCADE
);