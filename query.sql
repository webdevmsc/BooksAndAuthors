CREATE TABLE Authors 
(
id INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
full_name VARCHAR(255) NOT NULL,
dob Date NULL
);

CREATE TABLE Books 
(
id INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
title VARCHAR(255) NOT NULL,
description TEXT NOT NULL,
edition VARCHAR(255) NOT NULL,
published_at Date NULL
);

CREATE TABLE Books_Authors
(
bookID INT NOT NULL,
authorID INT NOT NULL,
FOREIGN KEY (bookID) REFERENCES Books (id) ON DELETE CASCADE,
FOREIGN KEY (authorID) REFERENCES Authors (id) ON DELETE CASCADE,
);

insert into Authors (full_name, dob) values ('Cully Laxtonne', '1990-04-14 18:01:14');
insert into Authors (full_name, dob) values ('Augusto Walding', '1983-05-22 13:54:59');
insert into Authors (full_name, dob) values ('Winna Frankish', '2006-03-30 04:19:56');
insert into Authors (full_name, dob) values ('Maddalena Trigg', '2014-08-06 10:19:20');
insert into Authors (full_name, dob) values ('Ola Pechet', '2017-02-16 18:07:09');
insert into Authors (full_name, dob) values ('Thorn Sphinxe', '2011-03-04 00:10:44');
insert into Authors (full_name, dob) values ('Ashleigh Olkowicz', '1977-09-13 12:34:50');
insert into Authors (full_name, dob) values ('Elbertine Dulson', '2007-09-15 21:45:55');
insert into Authors (full_name, dob) values ('Janice Burgh', '1970-01-28 16:27:54');
insert into Authors (full_name, dob) values ('Gustave Kiley', '1974-11-16 02:26:35');
insert into Authors (full_name, dob) values ('Ardith Tatteshall', '2017-09-22 11:15:52');
insert into Authors (full_name, dob) values ('Ronny Benettini', '1982-01-15 19:29:43');
insert into Authors (full_name, dob) values ('Joaquin McGenn', '1989-03-06 22:03:54');
insert into Authors (full_name, dob) values ('Roz Lavery', '1993-11-30 12:20:52');
insert into Authors (full_name, dob) values ('Ellerey Kondratenko', '2007-06-01 23:26:23');
insert into Authors (full_name, dob) values ('Vincents Rayburn', '1971-01-14 09:43:47');
insert into Authors (full_name, dob) values ('Clay Lythgoe', '1995-01-31 07:21:50');
insert into Authors (full_name, dob) values ('Mendy Gubbin', '2020-09-15 00:15:13');
insert into Authors (full_name, dob) values ('Molli Alten', '1977-05-25 08:52:42');
insert into Authors (full_name, dob) values ('Dianemarie Shawel', '2003-08-20 14:24:31');
insert into Authors (full_name, dob) values ('Andie Esp', '1984-09-18 21:33:56');
insert into Authors (full_name, dob) values ('Corrine Esley', '1967-06-05 07:31:37');
insert into Authors (full_name, dob) values ('Boony Epsly', '1967-06-12 06:45:52');
insert into Authors (full_name, dob) values ('Anabal Coniff', '1961-08-30 08:11:41');
insert into Authors (full_name, dob) values ('Suzi Dancy', '1985-03-23 21:08:29');
insert into Authors (full_name, dob) values ('Elicia Winkett', '2003-05-25 09:28:24');
insert into Authors (full_name, dob) values ('Luke Wyldish', '1972-08-18 19:52:39');
insert into Authors (full_name, dob) values ('Matthus Schettini', '1996-01-23 23:23:46');
insert into Authors (full_name, dob) values ('Cristiano Boyce', '1970-12-31 20:55:00');
insert into Authors (full_name, dob) values ('Abbi Braine', '1966-09-01 15:03:20');
insert into Authors (full_name, dob) values ('Cathie Tampen', '2007-01-21 05:56:36');
insert into Authors (full_name, dob) values ('Emylee Soldner', '1958-06-12 11:52:07');
insert into Authors (full_name, dob) values ('Lalo Possa', '1990-09-23 10:07:19');
insert into Authors (full_name, dob) values ('Giacobo Tedder', '1972-02-14 06:29:54');
insert into Authors (full_name, dob) values ('Early Burdus', '1963-05-22 12:39:15');

insert into Books (title, description, edition, published_at) values ('Final Conflict, The (a.k.a. Omen III: The Final Conflict)', 'Down-sized clear-thinking algorithm', '386-66-6859', '2009-05-01 12:51:37');
insert into Books (title, description, edition, published_at) values ('California', 'Profound fault-tolerant knowledge base', '119-30-8919', '2013-10-10 13:22:48');
insert into Books (title, description, edition, published_at) values ('Cookout, The', 'Right-sized dynamic ability', '619-54-1244', '1999-08-13 15:02:59');
insert into Books (title, description, edition, published_at) values ('Girlhood', 'Profit-focused mission-critical process improvement', '868-21-6194', '2002-04-08 22:10:06');
insert into Books (title, description, edition, published_at) values ('Everything Will Be Fine', 'Reverse-engineered even-keeled collaboration', '882-21-4509', '2018-08-09 03:01:00');
insert into Books (title, description, edition, published_at) values ('AM1200', 'Mandatory logistical frame', '467-77-0932', '2015-10-11 11:09:16');
insert into Books (title, description, edition, published_at) values ('Four Horsemen', 'Progressive transitional system engine', '313-73-4035', '1994-04-24 20:15:09');
insert into Books (title, description, edition, published_at) values ('Tooth Fairy', 'Progressive optimal protocol', '679-03-5466', '2007-08-08 19:08:35');
insert into Books (title, description, edition, published_at) values ('Visiting Hours', 'Robust even-keeled support', '407-86-4687', '1993-09-17 22:12:53');
insert into Books (title, description, edition, published_at) values ('Switch', 'Configurable dynamic secured line', '706-69-3111', '1998-04-02 16:01:03');
insert into Books (title, description, edition, published_at) values ('Planes: Fire & Rescue', 'Re-contextualized leading edge task-force', '588-50-8757', '2017-09-09 19:12:28');
insert into Books (title, description, edition, published_at) values ('Beginners', 'Ergonomic full-range help-desk', '234-20-0690', '2014-11-19 04:06:59');
insert into Books (title, description, edition, published_at) values ('Tae Guk Gi: The Brotherhood of War (Taegukgi hwinalrimyeo)', 'Synchronised static utilisation', '131-45-2098', '1986-06-13 20:14:53');
insert into Books (title, description, edition, published_at) values ('Tempest, The', 'Implemented solution-oriented monitoring', '388-83-2197', '2011-09-30 06:13:44');
insert into Books (title, description, edition, published_at) values ('Wayne''s World 2', 'Fundamental composite matrix', '739-66-8728', '1992-06-26 18:34:50');
insert into Books (title, description, edition, published_at) values ('Comebacks, The', 'Pre-emptive intermediate framework', '700-26-7275', '1987-06-07 04:08:00');
insert into Books (title, description, edition, published_at) values ('Mezzo Forte', 'Polarised optimizing hardware', '140-23-7140', '1980-10-13 03:18:25');
insert into Books (title, description, edition, published_at) values ('Anything Goes', 'Up-sized clear-thinking encoding', '605-27-8060', '2009-12-22 20:30:36');
insert into Books (title, description, edition, published_at) values ('Bride Comes Home, The', 'Optional 4th generation moratorium', '821-91-9425', '2008-12-04 16:31:37');
insert into Books (title, description, edition, published_at) values ('Contempt (Mépris, Le)', 'Multi-channelled fresh-thinking protocol', '426-04-1842', '2003-12-02 11:22:02');
insert into Books (title, description, edition, published_at) values ('Hiding Cot (Piilopirtti)', 'Down-sized hybrid budgetary management', '863-97-6245', '1982-03-26 05:23:33');
insert into Books (title, description, edition, published_at) values ('God Help the Girl', 'Ameliorated scalable function', '320-39-7241', '2012-10-17 02:18:55');
insert into Books (title, description, edition, published_at) values ('Study in Terror, A', 'Streamlined radical system engine', '543-48-2487', '2000-08-03 07:38:35');
insert into Books (title, description, edition, published_at) values ('These Final Hours', 'Polarised global website', '230-02-2686', '1985-11-06 06:48:19');
insert into Books (title, description, edition, published_at) values ('Narrow Margin', 'Business-focused explicit analyzer', '358-42-4517', '1995-09-18 10:10:32');
insert into Books (title, description, edition, published_at) values ('Mad Love (Juana la Loca)', 'Organic next generation methodology', '458-15-5123', '1989-12-06 15:48:01');
insert into Books (title, description, edition, published_at) values ('About Last Night', 'Enterprise-wide user-facing monitoring', '811-72-1878', '1999-10-20 07:24:16');
insert into Books (title, description, edition, published_at) values ('We Bought a Zoo', 'Configurable human-resource system engine', '784-94-8309', '1986-01-31 21:17:41');
insert into Books (title, description, edition, published_at) values ('Bandits', 'Enterprise-wide contextually-based contingency', '362-60-5618', '2010-10-10 00:01:30');
insert into Books (title, description, edition, published_at) values ('T-Men', 'User-friendly zero tolerance help-desk', '706-74-1395', '2016-11-20 23:02:18');
insert into Books (title, description, edition, published_at) values ('Predator', 'Switchable tertiary challenge', '866-83-5084', '2020-12-19 20:58:28');
insert into Books (title, description, edition, published_at) values ('20,000 Years in Sing Sing', 'Vision-oriented client-driven flexibility', '245-48-8848', '2006-05-06 07:58:43');
insert into Books (title, description, edition, published_at) values ('Purple Butterfly (Zi hudie)', 'Future-proofed client-driven knowledge base', '567-10-9345', '1989-10-17 09:41:12');
insert into Books (title, description, edition, published_at) values ('Lorna''s Silence (Le silence de Lorna)', 'Face to face leading edge software', '470-66-7685', '1997-02-20 01:21:43');
insert into Books (title, description, edition, published_at) values ('Irma la Douce', 'Universal context-sensitive data-warehouse', '669-36-2222', '2007-03-22 21:25:26');

INSERT INTO Books_Authors([bookID],[authorID]) VALUES(1,19),(2,31),(3,3),(4,35),(5,26),(6,28),(7,18),(8,30),(9,1),(10,16);
INSERT INTO Books_Authors([bookID],[authorID]) VALUES(11,7),(12,27),(13,10),(14,19),(15,19),(16,33),(17,25),(18,27),(19,18),(20,34);
INSERT INTO Books_Authors([bookID],[authorID]) VALUES(21,17),(22,16),(23,4),(24,21),(25,19),(26,2),(27,23),(28,12),(29,21),(30,3);
INSERT INTO Books_Authors([bookID],[authorID]) VALUES(31,13),(32,18),(33,28),(34,20),(35,25);



