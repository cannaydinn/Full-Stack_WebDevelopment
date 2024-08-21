## test veritabanınızda employee isimli sütun bilgileri id(INTEGER), name VARCHAR(50), birthday DATE, email VARCHAR(100) olan bir tablo oluşturalım.

    CREATE TABLE employee(
	id INTEGER,
	name VARCHAR(50),
	birthday DATE,
	email VARCHAR(100)
);


## Oluşturduğumuz employee tablosuna 'Mockaroo' servisini kullanarak 50 adet veri ekleyelim.

    insert into employee (id, name, birthday, email) values (1, 'Lisa', '2023-09-30', 'lhumphery0@microsoft.com');
    insert into employee (id, name, birthday, email) values (2, 'Jennie', '2023-10-15', 'jbuzzing1@xinhuanet.com');
    insert into employee (id, name, birthday, email) values (3, 'Rahal', '2023-01-26', 'rschiesterl2@example.com');
    insert into employee (id, name, birthday, email) values (4, 'Camile', '2022-12-13', 'cmacdonald3@smugmug.com');
    insert into employee (id, name, birthday, email) values (5, 'Moses', '2023-09-27', 'maddenbrooke4@stumbleupon.com');
    insert into employee (id, name, birthday, email) values (6, 'Kermit', '2022-12-18', 'kswaffield5@dropbox.com');
    insert into employee (id, name, birthday, email) values (7, 'Kahlil', '2023-03-26', 'krawsthorne6@uol.com.br');
    insert into employee (id, name, birthday, email) values (8, 'Tabitha', '2023-03-05', 'tpavie7@instagram.com');
    insert into employee (id, name, birthday, email) values (9, 'Gail', '2023-04-09', 'gdaeth8@senate.gov');
    insert into employee (id, name, birthday, email) values (10, 'Amalia', '2023-03-20', 'areicharz9@cornell.edu');
    insert into employee (id, name, birthday, email) values (11, 'Ulises', '2023-03-08', 'ugubbinsa@economist.com');
    insert into employee (id, name, birthday, email) values (12, 'Donetta', '2023-05-10', 'dborelb@soundcloud.com');
    insert into employee (id, name, birthday, email) values (13, 'Kayne', '2022-11-30', 'kbalassic@parallels.com');
    insert into employee (id, name, birthday, email) values (14, 'Fidel', '2023-07-20', 'fmarcqd@mysql.com');
    insert into employee (id, name, birthday, email) values (15, 'Konstantine', '2023-01-20', 'kfosserde@hibu.com');
    insert into employee (id, name, birthday, email) values (16, 'Dulciana', '2023-10-16', 'dbartholinf@umich.edu');
    insert into employee (id, name, birthday, email) values (17, 'Estevan', '2023-03-06', 'etointong@yellowpages.com');
    insert into employee (id, name, birthday, email) values (18, 'Leeland', '2023-05-13', 'lcrenageh@netscape.com');
    insert into employee (id, name, birthday, email) values (19, 'Westbrooke', '2023-02-15', 'wandrzejczaki@drupal.org');
    insert into employee (id, name, birthday, email) values (20, 'Jeniffer', '2023-03-18', 'jlotteringtonj@i2i.jp');
    insert into employee (id, name, birthday, email) values (21, 'Merna', '2023-05-04', 'mrowthornek@yolasite.com');
    insert into employee (id, name, birthday, email) values (22, 'Alasteir', '2023-04-12', 'adallmanl@blogger.com');
    insert into employee (id, name, birthday, email) values (23, 'Erica', '2023-02-15', 'erichmontm@fema.gov');
    insert into employee (id, name, birthday, email) values (24, 'Jannel', '2022-12-24', 'jsimonazzin@jimdo.com');
    insert into employee (id, name, birthday, email) values (25, 'Porty', '2022-11-18', 'pmelmotho@home.pl');
    insert into employee (id, name, birthday, email) values (26, 'Florri', '2023-03-11', 'fgoymerp@bloglines.com');
    insert into employee (id, name, birthday, email) values (27, 'Kenn', '2023-03-01', 'kabramq@globo.com');
    insert into employee (id, name, birthday, email) values (28, 'Sharona', '2022-12-02', 'spallentr@smh.com.au');
    insert into employee (id, name, birthday, email) values (29, 'Karlotta', '2023-10-07', 'kbaxendales@cbslocal.com');
    insert into employee (id, name, birthday, email) values (30, 'Theodore', '2023-06-30', 'tdungeet@webnode.com');
    insert into employee (id, name, birthday, email) values (31, 'Costa', '2023-04-07', 'cgreenardu@usatoday.com');
    insert into employee (id, name, birthday, email) values (32, 'Bibbye', '2023-02-20', 'bmeharryv@berkeley.edu');
    insert into employee (id, name, birthday, email) values (33, 'Alena', '2023-08-18', 'aellesw@dell.com');
    insert into employee (id, name, birthday, email) values (34, 'Stevy', '2023-08-25', 'sbeaux@chronoengine.com');
    insert into employee (id, name, birthday, email) values (35, 'Jessie', '2023-05-28', 'jrappery@sogou.com');
    insert into employee (id, name, birthday, email) values (36, 'Trudy', '2023-09-15', 'tpringz@shutterfly.com');
    insert into employee (id, name, birthday, email) values (37, 'Adora', '2023-09-24', 'awehden10@phpbb.com');
    insert into employee (id, name, birthday, email) values (38, 'Melamie', '2023-10-09', 'mswafford11@ycombinator.com');
    insert into employee (id, name, birthday, email) values (39, 'Averyl', '2023-01-26', 'agudahy12@icq.com');
    insert into employee (id, name, birthday, email) values (40, 'Kristofor', '2023-09-23', 'kyarnell13@ebay.com');
    insert into employee (id, name, birthday, email) values (41, 'Josephina', '2023-05-13', 'jcooling14@china.com.cn');
    insert into employee (id, name, birthday, email) values (42, 'Delphinia', '2022-11-06', 'dalders15@biglobe.ne.jp');
    insert into employee (id, name, birthday, email) values (43, 'Lucille', '2023-01-23', 'lconnop16@redcross.org');
    insert into employee (id, name, birthday, email) values (44, 'Keene', '2022-10-29', 'kremon17@godaddy.com');
    insert into employee (id, name, birthday, email) values (45, 'Bronnie', '2023-04-05', 'bhopfer18@psu.edu');
    insert into employee (id, name, birthday, email) values (46, 'Ric', '2023-01-31', 'rwimms19@state.gov');
    insert into employee (id, name, birthday, email) values (47, 'Jesselyn', '2023-03-05', 'jbirkby1a@sitemeter.com');
    insert into employee (id, name, birthday, email) values (48, 'Fay', '2022-11-05', 'flackeye1b@miibeian.gov.cn');
    insert into employee (id, name, birthday, email) values (49, 'Jacinthe', '2022-12-16', 'jbrassington1c@twitter.com');
    insert into employee (id, name, birthday, email) values (50, 'Yoshi', '2023-07-25', 'ycolbran1d@nationalgeographic.com');



## Sütunların her birine göre diğer sütunları güncelleyecek 5 adet UPDATE işlemi yapalım.

    UPDATE employee SET name = 'Can' WHERE id = 1;
    UPDATE employee SET birthday = '2001-01-02' WHERE id = 2;
    UPDATE employee SET name = 'Aydin' WHERE id = 3;
    UPDATE employee SET email = 'can@aydin.com' WHERE id = 4;
    UPDATE employee SET name = 'Emir' WHERE id = 5;


## Sütunların her birine göre ilgili satırı silecek 5 adet DELETE işlemi yapalım.

    DELETE FROM employee WHERE name = 'Can' ;
    DELETE FROM employee WHERE birthday = '2001-01-02';
    DELETE FROM employee WHERE name = 'Aydin' ;
    DELETE FROM employee WHERE email = 'can@aydin.com' ;
    DELETE FROM employee WHERE name = 'Emir' ;