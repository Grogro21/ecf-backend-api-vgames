/* Microsoft SQL Server Script */

/* PUBLISHERS */
INSERT INTO `publisher` (`name`) VALUES ('Gizmondo Games'); /* id = 1 */
INSERT INTO `publisher` (`name`) VALUES ('Gizmondo Studios'); /* id = 2 */
INSERT INTO `publisher` (`name`) VALUES ('Fathammer');/* id = 3 */
INSERT INTO `publisher` (`name`) VALUES ('Gizmondo Eur Ltd');/* id = 4 */

/* GAMES */
INSERT INTO `gizmondo` (`publisher_id`, `game`, `year`, `dev`) VALUES (1, 'Classic Compendium', 2005, 'AI Factory'); /* id = 1 */
INSERT INTO `gizmondo` (`publisher_id`, `game`, `year`, `dev`) VALUES (1, 'Classic Compendium 2', 2005, 'AI Factory');
INSERT INTO `gizmondo` (`publisher_id`, `game`, `year`, `dev`) VALUES (2, 'Fathammer Classics Pack', 2005, 'Fathammer/Ninai Games/Vasara Games');
INSERT INTO `gizmondo` (`publisher_id`, `game`, `year`, `dev`) VALUES (1, 'FIFA Soccer 2005', 2005, 'Exient Entertainment/Electronic Arts Canada');
INSERT INTO `gizmondo` (`publisher_id`, `game`, `year`, `dev`) VALUES (3, 'Gizmondo Motocross 2005', 2005, 'Housemarque');
INSERT INTO `gizmondo` (`publisher_id`, `game`, `year`, `dev`) VALUES (3, 'Hockey Rage 2005', 2005, 'Chairman & Board');
INSERT INTO `gizmondo` (`publisher_id`, `game`, `year`, `dev`) VALUES (2, 'Interstellar Flames 2', 2005, 'Xen Games');
INSERT INTO `gizmondo` (`publisher_id`, `game`, `year`, `dev`) VALUES (3, 'Pocket Ping Pong 2005', 2005, 'Netdol');
INSERT INTO `gizmondo` (`publisher_id`, `game`, `year`, `dev`) VALUES (2, 'Point of Destruction', 2005, 'Gizmondo Studios Manchester');
INSERT INTO `gizmondo` (`publisher_id`, `game`, `year`, `dev`) VALUES (4, 'Richard Burns Rally', 2005, 'Gizmondo Studios Manchester');
INSERT INTO `gizmondo` (`publisher_id`, `game`, `year`, `dev`) VALUES (1, 'SSX 3', 2005, 'Exient Entertainment/Electronic Arts');
INSERT INTO `gizmondo` (`publisher_id`, `game`, `year`, `dev`) VALUES (1, 'Sticky Balls', 2005, 'Gizmondo Studios Manchester');
INSERT INTO `gizmondo` (`publisher_id`, `game`, `year`, `dev`) VALUES (3, 'Toy Golf', 2005, 'Ninai Games');
INSERT INTO `gizmondo` (`publisher_id`, `game`, `year`, `dev`) VALUES (4, 'Trailblazer', 2005, 'Gizmondo Studios Manchester'); /* id = 14 */
