--UC-1-AbilityToCreateAddressBookService
create database Address_Book_Service

--UC-2-CreatATableOfAddressBookTable
create table AddressBookTable( Emp_Id int identity(1,1) primary key,
FirstName varchar(20),LastName varchar(20),Address varchar(20),City varchar(20),
State varchar(20),Zip BIGINT,PhoneNumber BIGINT);

Select * from AddressBookTable

--UC-3-INSERT_NEW_CONTACT_IN_ADDRESS_BOOK
Insert into AddressBookTable(FirstName,LastName,Address,City,State,Zip,PhoneNumber,Type)
values ('nikita','daksh','abc','agra','delhi','440059','98556412356',1);
Select * from AddressBookTable
alter table AddressBookTable add Email varchar(222)

--UC-4-AbilityToEditExistingContact
update AddressBookTable set zip=442565 where FirstName='nikita'
Select * from AddressBookTable

--UC-5-AbilityToDeleteContactByUsingPersonName
delete from AddressBookTable where FirstName='gaurav'
Select * from AddressBookTable

--UC-6-AbilityToRetrivePersonByCityOrStateFromAddressBook
select * from AddressBookTable where city='nagpur' AND state='maharashtra'
select * from AddressBookTable where city='agra' or state='banglore'

--UC-7-Ability to understand the size of addressbook by City and State
select count(city) from AddressBookTable;
select count(state) from AddressBookTable;

--UC-8-Ability to retrieve entries sorted alphabetically by Person’s name for A given city
select city from AddressBookTable order by FirstName

--UC-9-Ability to identify each Address Book with name and Type
Alter table AddressBookTable add Type varchar(20)
Select * from AddressBookTable

update AddressBookTable set Type ='myself' where FirstName='pranali'; 
update AddressBookTable set Type ='friend' where FirstName='nikita';
update AddressBookTable set Type ='brother' where FirstName='gaurav';

--UC-10-COUNT BY TYPE
select count(Type) from AddressBookTable;

--UC-11-Ability To Add Person To Both Family And Friend
insert into AddressBookTable(FirstName)values ('shrawani')
Select * from AddressBookTable
update AddressBookTable set Type ='sis' where FirstName='shrawani';
update AddressBookTable set Type ='ybrother' where FirstName='agastya';

--UC-12
create table AddressType(TypeID int identity(1,1) primary key, Type varchar(20))
insert into AddressType(Type) VALUES ('Brother')
 drop table AddressType
select * from AddressType

drop table AddressBookTable

select BookTable.FirstName,BookTable.LastName,BookTable.Address,BookTable.City,BookTable.State,BookTable.Zip,
BookTable.PhoneNumber,AddressBookType.Type from AddressBookTable BookTable Inner Join AddressType AddressBookType on 
BookTable.Type=AddressBookType.TypeID






