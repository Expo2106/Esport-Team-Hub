USE esport_team_hub;

CREATE TABLE IF NOT EXISTS transferhistory (
transfer_id INT AUTO_INCREMENT PRIMARY KEY,
listing_id INT UNIQUE,
user_id INT,
from_team_id INT,
to_team_id INT,
transfer_fee DECIMAL(12,2),
transfer_date DATE,
FOREIGN KEY (listing_id) REFERENCES transfermarket(listing_id) 
ON DELETE SET NULL
ON UPDATE CASCADE,
FOREIGN KEY (user_id) REFERENCES user(user_id) 
ON DELETE CASCADE
ON UPDATE CASCADE,
FOREIGN KEY (from_team_id) REFERENCES team(team_id) 
ON DELETE CASCADE
ON UPDATE CASCADE,
FOREIGN KEY (to_team_id) REFERENCES team(team_id) 
ON DELETE CASCADE
ON UPDATE CASCADE
);
