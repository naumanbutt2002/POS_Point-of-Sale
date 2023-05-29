
create database POS;
use POS;
create table SupplierTb(
	Supplier_ID int not null identity(1,1),
	Supplier_name varchar(50),
	Supplier_City varchar(50),
	Supplier_phone varchar(50),
	PRIMARY KEY (Supplier_ID)
);

--Insert into SupplierTb (Supplier_name,Supplier_City,Supplier_phone) values('Zesshan','Sialkot','0321-6020450');
--SELECT * FROM SupplierTb

Create table ProductTable(
		PId Int Not null identity(1,1),
		PName VARCHAR(50),
		PCat VARCHAR(50),
		PPrice decimal,
		PQty Int,
		SupId Int FOREIGN KEY REFERENCES SupplierTb(Supplier_ID),
		Primary Key(PId)
);

--Insert into ProductTable values('HpLaptop','Computer',50000,5,1);
--Select * From ProductTable;

Create table EmpTable(
	EmpId Int Not Null Identity(1,1),
	EmpName Varchar(50) NOT NULL,
	EmpDesignation Varchar(50),
	EmpNo Varchar(50),
	EmpSalary decimal NOT NULL,
	Primary Key(EmpId)
);

--Insert into EmpTable values('Salman','Manager','0313-3243212',50000);
Select * From EmpTable;

Create table CustomerTable(
	CustId Int Not Null Identity(1,1),
	CustName Varchar(50) NOT NULL,
	CustPhone Varchar(50),
	CustEmail Varchar(50),
	CustAge Int NOT NULL,
	CustAddress Varchar(50) NOT NULL,
	Primary Key(CustId)
);

--Insert into CustomerTable values('Nauman','0313-7232342','nauman100percent@gmail.com',21,'Sialkot');
--Select * From CustomerTable;

Create table BillTable(
	BNum Int Not Null Identity(1,1),
	BDate DateTime NOT NULL,
	CustId Int FOREIGN KEY REFERENCES CustomerTable(CustId),
	CustName Varchar(50),
	ProductName Varchar(50),
	ProductQty int,
	Amount Decimal NOT NULL,

	--EmpId Int FOREIGN KEY REFERENCES EmpTable(EmpId),
	--EmpName Varchar(50) NOT NULL,
	Primary Key(BNum)
);

--Insert into BillTable values('2022-10-29',1,'Nauman','Cash On Delivery',1000);
Select * From BillTable;
Create table login_tb(
	userId int Not Null Identity(1,1),
	username varchar (50),
	pass varchar(16),
	designation varchar(50),
	hint varchar(50),
);
--drop table login_tb
Insert into login_tb values('admin','admin123','admin','null');
select * from login_tb;
--DELETE FROM login_tb WHERE username='Nauman';
--Truncate table login_tb

