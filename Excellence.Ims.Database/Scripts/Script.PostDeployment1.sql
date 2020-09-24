/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

INSERT INTO [AttributeName](Title, CategoryId)
VALUES
('Lighting', 1),
('Controller', 1),
('Power Supply', 1),
('Fixtures', 1),
('Accessories', 1),
('Dimensions', 2, 2),
('Chip Type', 2),
('Power Rating', 2),
('Color Support', 2),
('White Temperature', 2),
('Chip Density', 2),
('Brightness', 2),
('CRI Rating', 2),
('IP Rating', 2),
('Cut Interval', 2),
('Backing', 2),
('Lifespan', 2),
('Warranty', 2),
('Type', 3),
('Channels', 3),
('Connectivity', 3),
('Included Remote', 3),
('Compatible Smart Home Assistants', 3),
('Power Rating', 4),
('Input', 4),
('Connector', 4),
('Material', 5),
('Profile Type', 5),
('Diffuser Material', 5),
('Coverage Angle', 5);

