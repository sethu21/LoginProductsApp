﻿CREATE TABLE Users
(
    Id INT PRIMARY KEY IDENTITY(1,1),  
    Username NVARCHAR(50) NOT NULL,    
    Name NVARCHAR(50) NOT NULL,        
    Password NVARCHAR(50) NOT NULL,    
    Email NVARCHAR(50) NOT NULL        
);
