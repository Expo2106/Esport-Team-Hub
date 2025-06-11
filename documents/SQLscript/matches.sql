USE esport_team_hub;

CREATE TABLE IF NOT EXISTS matches (
match_id INT AUTO_INCREMENT PRIMARY KEY,
comp_name VARCHAR(100),
match_date DATETIME NOT NULL,
match_format ENUM('Bo 3', 'Bo 5', 'Bo 7'),
team1_id INT NOT NULL,
team2_id INT NOT NULL,
score_team1 INT,
score_team2 INT,
status ENUM ('Scheduled', 'LIVE', 'Completed', 'Postponed', 'Cancelled') NOT NULL DEFAULT ('Scheduled'),
vod_url VARCHAR(255),
FOREIGN KEY (team1_id) REFERENCES team(team_id)
ON DELETE CASCADE
ON UPDATE CASCADE,
FOREIGN KEY (team2_id) REFERENCES team(team_id)
ON DELETE CASCADE
ON UPDATE CASCADE
);
