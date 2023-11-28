CREATE TABLE
    IF NOT EXISTS accounts(
        id VARCHAR(255) NOT NULL primary key COMMENT 'primary key',
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
        name varchar(255) COMMENT 'User Name',
        email varchar(255) COMMENT 'User Email',
        picture varchar(255) COMMENT 'User Picture'
    ) default charset utf8 COMMENT '';

CREATE TABLE
    IF NOT EXISTS homes(
        id INT NOT NULL PRIMARY KEY AUTO_INCREMENT COMMENT 'this is the id of a home',
        name CHAR(255) NOT NULL COMMENT 'this is the home name'
    ) default charset utf8 COMMENT '';

INSERT INTO homes (name) VALUES('LA Mansion');