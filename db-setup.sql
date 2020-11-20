-- USE YOUR-DB-HERE;

-- CREATE TABLE webbinggrips (
--   id int NOT NULL AUTO_INCREMENT,
--   name VARCHAR(255),
--   manufacturer VARCHAR(255),
--   img VARCHAR(255),
--   componenttype VARCHAR(255),
--   material VARCHAR(255),
--   weight int,
--   wll decimal,
--   mbs decimal,
--   commonslipthreshold VARCHAR(255),
--   connectiontype VARCHAR(255),
--   compatiblewebbingwidth VARCHAR(255),
--   price decimal,
--   PRIMARY KEY (id)
-- )

-- CREATE TABLE manufacturers (
--   id int NOT NULL AUTO_INCREMENT,
--   name VARCHAR(255),
--   img VARCHAR(255),
--   yearestablished VARCHAR(255),
--   website VARCHAR(255),
--   facebook VARCHAR(255),
--   PRIMARY KEY (id)
-- )

  -- CREATE TABLE lineslides (
  --   id int NOT NULL AUTO_INCREMENT,
  --     manufacturerid int NOT NULL,
  --     img VARCHAR(255),   
  --     name VARCHAR(255) NOT NULL,
  --     manufacturer VARCHAR(255) NOT NULL,
  --     componenttype VARCHAR(255) NOT NULL,
  --     material VARCHAR(255),
  --     weight int, 
  --     wll int,
  --     mbs int,
  --     webbingwidth VARCHAR(255), 
  --     slidertype VARCHAR(255),
  --     innerwidth int,
  --     price int,
  --     PRIMARY KEY (id)
  -- );

-- DROP TABLE IF EXISTS webbinggrips;

-- CREATE TABLE leashrings (
--      id int NOT NULL AUTO_INCREMENT,
--      manufacturerid int NOT NULL,
--      name VARCHAR(255) NOT NULL,
--     img VARCHAR(255),
--      manufacturer VARCHAR(255) NOT NULL,
--      componenttype VARCHAR(255) NOT NULL,
--      material VARCHAR(255),
--      weight decimal,
--      wll  decimal, 
--      mbs decimal,
--      materialdiameter decimal, 
--      innerdiameter decimal, 
--      outerdiameter decimal, 
--      price decimal,
--      PRIMARY KEY (id)
-- );

-- CREATE TABLE rigs (
--      id int NOT NULL AUTO_INCREMENT,
--      name VARCHAR(255) NOT NULL,
--      description VARCHAR(255),
--      userId VARCHAR(255),
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
-- DROP TABLE IF EXISTS rig;
-- DROP TABLE IF EXISTS lineslides;
