create database library;


create table signIn(
id int NOT NUll IDENTITY(1,1) primary key,
username varchar(50),
email varchar(100),
pass varchar(40)
)

insert into signIn (username,pass) values('jyoti','123');
insert into signIn (username,pass) values('purba','456');

select * from SignIn

create table AddBook(
bid int Not Null IDENTITY(1,1) primary key,
bName varchar(250) not null,
bAuthor varchar(250) not null,
bPubl varchar(250) not null,
bPDate varchar(250) not null,
bPrice bigint not null,
bQuan bigint not null,
)
insert into AddBook(bName,bAuthor,bPubl,bPDate,bPrice,bQuan) values ('java','shiva','tje','12/01/2022',1234,2);
 

select * from AddBook

create table AddStudent(
stuid int Not Null IDENTITY(1,1) primary key,
sname varchar(250) not null,
enroll varchar(250) not null,
dep varchar(250) not null,
sem varchar(250) not null,
contact bigint not null,
email varchar(250) not null
)

select * from AddStudent


CREATE TABLE IRBook (
    id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    std_enroll VARCHAR(250) NOT NULL,
    std_name VARCHAR(250) NOT NULL,
    std_dep VARCHAR(250) NOT NULL,
    std_sem VARCHAR(250) NOT NULL,
    std_contact BIGINT NOT NULL,
    std_email VARCHAR(250) NOT NULL,
    book_name VARCHAR(250) NOT NULL,
    book_issue_date VARCHAR(250) NOT NULL,
    book_return_date VARCHAR(250)
);

INSERT INTO IRBook  (std_enroll, std_name, std_dep, std_sem, std_contact, std_email, book_name, book_issue_date) VALUES (234, 'jyoti',  6,83457097, 'jnfk@jmsdk', 'njdn', 23/2/2022);




select * from IRBook


create table signUp(
id int NOT NUll IDENTITY(1,1) primary key,
username varchar(50),
email varchar(100),
pass varchar(40)
)

insert into signUp (username,email,pass) values('jyoti','jkumari543@rku.ac.in','123');
insert into signUp (username,email,pass) values('purba','spurba001@rku.ac.in','456');

select * from SignUp
