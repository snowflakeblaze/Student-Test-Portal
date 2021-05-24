create table portalUser(
portalUser_ID	integer identity(1,1),
username		varchar(30),
portalPassword	varchar(30),
firstName		varchar(30),
lastName		varchar(30),
mark			integer,
accountType		integer,

primary key (portalUser_ID)
)

create table question(
question_ID		integer,
questionText	varchar(500),
optionA			varchar(500),
optionB			varchar(500),
optionC			varchar(500),
optionD			varchar(500),
correctAnswer	char(1),

primary key (question_ID)

)

create table studentAnswer(
portalUser_ID	integer,
question_ID		integer,
answer			char(1),

primary key (portalUser_ID, question_ID),
foreign key (portalUser_ID) references portalUser(portalUser_ID),
foreign key (question_ID) references question(question_ID)
)

insert into portalUser (username, portalPassword, firstName, lastName, accountType)
values ('DanE','Password12345','Daniel','Erasmus',1),
('jiga','11223344','Pritesh','Soma',0)

insert into portalUser (username, portalPassword, firstName, lastName, accountType, mark)
values ('demo', 'demo', 'demo', 'demo', 0, 30),
('demo', 'demo', 'demo', 'demo', 0, 80)

insert into question (question_ID, questionText, optionA, optionB, optionC, optionD, correctAnswer)
values 
(1,'How many seasons are there in a year?','one','four','six','none','B'),
(2,'What application are you conducting this test from?','Visual Studio','Android Studio','Netbeans','MySql','A'),
(3,'do you need training to improve yourself?','nope','yes','maybe','meh','B'),
(4,'Can all birds fly?','nope','yes','maybe','meh','B'),
(5,'Is this the last question?','nope','yes','maybe','meh','C')
