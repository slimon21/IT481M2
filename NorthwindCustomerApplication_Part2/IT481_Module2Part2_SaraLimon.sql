-- Step 1: Create server-level logins
USE master;
GO

-- Create SQL Server logins
CREATE LOGIN User_Sales WITH PASSWORD = 'Password123!';
CREATE LOGIN User_HR WITH PASSWORD = 'Password123!';
CREATE LOGIN User_CEO WITH PASSWORD = 'Password123!';
GO

-- Step 2: Switch to Northwind database
USE Northwind;
GO

-- Drop users and roles if they already exist
IF EXISTS (SELECT * FROM sys.database_principals WHERE name = 'User_Sales')
    DROP USER User_Sales;
IF EXISTS (SELECT * FROM sys.database_principals WHERE name = 'User_HR')
    DROP USER User_HR;
IF EXISTS (SELECT * FROM sys.database_principals WHERE name = 'User_CEO')
    DROP USER User_CEO;

IF EXISTS (SELECT * FROM sys.database_principals WHERE name = 'SalesRole')
    DROP ROLE SalesRole;
IF EXISTS (SELECT * FROM sys.database_principals WHERE name = 'HRRole')
    DROP ROLE HRRole;
IF EXISTS (SELECT * FROM sys.database_principals WHERE name = 'CEORole')
    DROP ROLE CEORole;
GO

-- Create roles
CREATE ROLE SalesRole;
CREATE ROLE HRRole;
CREATE ROLE CEORole;
GO

-- Create users mapped to logins
CREATE USER User_Sales FOR LOGIN User_Sales;
CREATE USER User_HR FOR LOGIN User_HR;
CREATE USER User_CEO FOR LOGIN User_CEO;
GO

-- Add users to roles
ALTER ROLE SalesRole ADD MEMBER User_Sales;
ALTER ROLE HRRole ADD MEMBER User_HR;
ALTER ROLE CEORole ADD MEMBER User_CEO;
GO

-- Grant table permissions by role
GRANT SELECT ON dbo.Customers TO SalesRole;
GRANT SELECT ON dbo.Orders TO SalesRole;

GRANT SELECT ON dbo.Employees TO HRRole;

GRANT SELECT ON dbo.Customers TO CEORole;
GRANT SELECT ON dbo.Orders TO CEORole;
GRANT SELECT ON dbo.Employees TO CEORole;
GO
