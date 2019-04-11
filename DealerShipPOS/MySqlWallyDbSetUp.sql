CREATE DATABASE BPWally;

USE BPWally;

CREATE TABLE Customer
(
	CustomerID int NOT NULL AUTO_INCREMENT,
    FirstName varchar(50) NOT NULL,
	LastName varchar(50) NOT NULL,
	PhoneNumber varchar(12),
    PRIMARY KEY (CustomerID)
);



CREATE TABLE Dealership
(
	DealerID int NOT NULL AUTO_INCREMENT,
    DealershipName varchar(50) NOT NULL,
    PRIMARY KEY (DealerID)
); 



CREATE TABLE Vehicle
(
	VIN varchar(11) NOT NULL,
    vYear int NOT NULL,
    Make varchar(10) NOT NULL,
    Model varchar(10) NOT NULL,
    Colour varChar(10) NOT NULL,
    kms int NOT NULL,
    wPrice int NOT NULL,
    inStock varchar(6) NOT NULL,
    PRIMARY KEY (VIN)
);


CREATE TABLE CustomerOrder
(
	OrderID int NOT NULL AUTO_INCREMENT,
    CustomerID int NOT NULL,
    OrderDate varchar(45) NOT NULL,
    OrderStatus varChar(10) NOT NULL,
    DealerID int NOT NULL,
	FOREIGN KEY (CustomerID)
        REFERENCES Customer(CustomerID),
	FOREIGN KEY (DealerID)
		REFERENCES Dealership (DealerID),
	PRIMARY KEY (OrderID)
);



CREATE TABLE OrderLine
(
	OrderID int NOT NULL,
	Vehicle varchar(11) NOT NULL,
    FOREIGN KEY (Vehicle)
        REFERENCES Vehicle(VIN),
	FOREIGN KEY (OrderID)
        REFERENCES CustomerOrder(OrderID),
	PRIMARY KEY (OrderID)
);





INSERT INTO Customer (FirstName, LastName, PhoneNumber)
	VALUES ("Wally's World of Wheels","Inc.","519-555-0000");

    
    
INSERT INTO Customer (FirstName, LastName, PhoneNumber)
	VALUES ("Norbert","Mika","416-555-1111");
    

    
INSERT INTO Customer (FirstName, LastName, PhoneNumber)
	VALUES ("Russell","Foubert","519-555-2222");
    

    
INSERT INTO Customer (FirstName, LastName, PhoneNumber)
	VALUES ("Sean","Clarke","519-555-3333");
    
    

INSERT INTO Dealership (DealershipName)
	VALUES ("Sports World");
    
    
    
INSERT INTO Dealership (DealershipName)
	VALUES ("Guelph Auto Mall");
    
    
    
INSERT INTO Dealership (DealershipName)
	VALUES ("Waterloo");
    
    
    
INSERT INTO Vehicle (VIN, vYear, Make, Model, Colour, kms, wPrice, inStock)
	VALUES ("58847722BRB", 2010, "Honda", "Civic", "Blue", 120332, 6500, "YES");
		
        
        
INSERT INTO Vehicle (VIN, vYear, Make, Model, Colour, kms, wPrice, inStock)
	VALUES ("26663747GTG", 2009, "Ford", "Focus", "Black", 89221, 8950, "YES");
    
    
    
INSERT INTO Vehicle (VIN, vYear, Make, Model, Colour, kms, wPrice, inStock)
	VALUES ("99277544LOL", 2012, "Volkswagen", "Jetta", "Silver", 156233, 13450, "YES");
    
    
    
INSERT INTO Vehicle (VIN, vYear, Make, Model, Colour, kms, wPrice, inStock)
	VALUES ("27764534RTB", 2013, "Dodge", "Ram", "Red", 211023, 10900, "YES");
    