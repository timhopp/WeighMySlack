-- USE YOUR-DB-HERE;

CREATE TABLE manufacturers (
  id int NOT NULL AUTO_INCREMENT,
  yearestablished VARCHAR(255),
  website VARCHAR(255),
  facebook VARCHAR(255),
  PRIMARY KEY (id)
)

  -- CREATE TABLE lineslides (
  --   id int NOT NULL AUTO_INCREMENT,
  --     manufacturerid int NOT NULL,
  --     name VARCHAR(255) NOt NULL,
  --     manufacturer VARCHAR(255) NOT NULL,
  --     material VARCHAR(255),
  --     weight int, 
  --     wll int,
  --     mbc int,
  --     webbingwidth VARCHAR(255), 
  --     slidertype VARCHAR(255),
  --     innerwidth int,
  --     price int,
  --     PRIMARY KEY (id)
  -- );

-- CREATE TABLE leashrings (
--      id int NOT NULL AUTO_INCREMENT,
--      manufacturerid int NOT NULL,
--      name VARCHAR(255) NOT NULL,
--      manufacturer VARCHAR(255) NOT NULL,
--      material VARCHAR(255),
--      weight int,
--      wll  int, 
--      mbs int,
--      materialdiameter int, 
--      innerdiameter int, 
--      outerdiameter int, 
--      price int,
--      PRIMARY KEY (id)
-- );

-- CREATE TABLE rig (
--      id int NOT NULL AUTO_INCREMENT,
--      name VARCHAR(255) NOT NULL,
--      description VARCHAR(255),
--      PRIMARY KEY (id)  
-- )

-- CREATE TABLE rigleashrings (
--   id int NOT NULL AUTO_INCREMENT,
--   leashringsId int NOT NULL,
--   rigId int NOT NULL, 
--   userId VARCHAR(255) NOT NULL,

--   PRIMARY KEY (id),
--   INDEX ( leashringsId, rigId),
--   INDEX ( userId),

--   FOREIGN KEY (leashringsId)
--     REFERENCES leashrings(id)
--     ON DELETE CASCADE,

--   FOREIGN KEY (rigId)
--   REFERENCES rig(id)
--   ON DELETE CASCADE 
-- )

-- CREATE TABLE vaults (
--     id int NOT NULL AUTO_INCREMENT,
--     name VARCHAR(255) NOT NULL,
--     description VARCHAR(255) NOT NULL,
--     userId VARCHAR(255),
--     INDEX userId (userId),  
--     PRIMARY KEY (id)
-- );

-- CREATE TABLE keeps (
--     id int NOT NULL AUTO_INCREMENT,
--     name VARCHAR(255) NOT NULL,
--     description VARCHAR(255) NOT NULL,
--     userId VARCHAR(255),
--     img VARCHAR(255),
--     isPrivate TINYINT,
--     views INT DEFAULT 0,
--     shares INT DEFAULT 0,
--     keeps INT DEFAULT 0,
--     INDEX userId (userId),
--     PRIMARY KEY (id)
-- );

-- CREATE TABLE vaultkeeps (
--     id int NOT NULL AUTO_INCREMENT,
--     vaultId int NOT NULL,
--     keepId int NOT NULL,
--     userId VARCHAR(255) NOT NULL,

--     PRIMARY KEY (id),
--     INDEX (vaultId, keepId),
--     INDEX (userId),

--     FOREIGN KEY (vaultId)
--         REFERENCES vaults(id)
--         ON DELETE CASCADE,

--     FOREIGN KEY (keepId)
--         REFERENCES keeps(id)
--         ON DELETE CASCADE
-- )


-- -- USE THIS LINE FOR GET KEEPS BY VAULTID
-- SELECT 
-- k.*,
-- vk.id as vaultKeepId
-- FROM vaultkeeps vk
-- INNER JOIN keeps k ON k.id = vk.keepId 
-- WHERE (vaultId = @vaultId AND vk.userId = @userId) 



-- -- USE THIS TO CLEAN OUT YOUR DATABASE
-- DROP TABLE IF EXISTS vaultkeeps;
-- DROP TABLE IF EXISTS vaults;
-- DROP TABLE IF EXISTS keeps;
-- DROP TABLE IF EXISTS users;
