/*
SELECT TOP (1000) [MigrationId]
      ,[ProductVersion]
  FROM [Products].[dbo].[__EFMigrationsHistory]
*/

SELECT TOP (100) * FROM [sysobjects] where 1=1 
    and type = 'U'
    -- and name like '%Product%'

    /*
    DROP TABLE __EFMigrationsHistory;
    DROP TABLE Product;
    DROP TABLE ProductCategory;
    DROP TABLE ProducTag;
    
    */

  SELECT TOP (100) * FROM [Products].[dbo].[Product];
  SELECT TOP (100) * FROM [Products].[dbo].[ProductCategory];
  SELECT TOP (100) * FROM [Products].[dbo].[ProductTag];

