INSERT INTO [Type](Title)
VALUES
('Simple'),
('Variable'),
('Variation');

INSERT INTO [ShippingClass](Title)
VALUES
('Small'),
('Standard'),
('Large');

INSERT INTO [Warranty](Title, Years)
VALUES
('1 Year Warranty', 1),
('2 Year Warranty', 2),
('3 Year Warranty', 3),
('4 Year Warranty', 4),
('5 Year Warranty', 5);

INSERT INTO [AttributeCategory](Title)
VALUES
('Includes'),
('Lighting'),
('Controller'),
('Power Supply'),
('Fixture');

INSERT INTO [AttributeName](Title, CategoryId)
VALUES
('Lighting', 1),
('Controller', 1),
('Power Supply', 1),
('Fixtures', 1),
('Accessories', 1),
('Dimensions', 2),
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