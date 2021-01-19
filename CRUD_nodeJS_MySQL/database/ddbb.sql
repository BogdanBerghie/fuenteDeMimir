-- to create a new database
CREATE DATABASE crud_nodejs_mysql;

-- to use database
use crud_nodejs_mysql;

-- creating a new table
CREATE TABLE user (
  id INT(6) UNSIGNED AUTO_INCREMENT PRIMARY KEY,
  name VARCHAR(50) NOT NULL,
  address VARCHAR(100) NOT NULL,
  phone VARCHAR(15)
);

-- to show all tables
show tables;

-- to describe table
describe user;