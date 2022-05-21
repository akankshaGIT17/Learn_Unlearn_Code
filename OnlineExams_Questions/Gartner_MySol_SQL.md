# SQL Test Assignment

Attached is a mysqldump of a database to be used during the test.

Below are the questions for this test. Please enter a full, complete, working SQL statement under each question. We do not want the answer to the question. We want the SQL command to derive the answer. We will copy/paste these commands to test the validity of the answer.

**Example:**

_Q. Select all users_

- Please return at least first_name and last_name

SELECT first_name, last_name FROM users;


------

**— Test Starts Here —**

1. Select users whose id is either 3,2 or 4
- Please return at least: all user fields
SELECT * FROM USERS WHERE id IN (3,2,4)
2. Count how many basic and premium listings each active user has
- Please return at least: first_name, last_name, basic, premium

select u.first_name, u.last_name, 
CASE
    WHEN l.status=2 THEN 'basic'
    WHEN  l.status=3 THEN 'premium'
   END AS status, COUNT(l.status) as count
   from users u 
join  listings l on u.Id=l.user_id group by u.first_name , u.last_name, l.status, u.Id
order by u.Id


3. Show the same count as before but only if they have at least ONE premium listing
- Please return at least: first_name, last_name, basic, premium
select u.first_name, u.last_name, 
CASE
    WHEN l.status=2 THEN 'basic'
    WHEN  l.status=3 THEN 'premium'
   END AS status,COUNT(l.status) as counts
   from users u 
join  listings l on u.Id=l.user_id 
group by u.first_name , u.last_name, l.status, u.Id
having 0 < (select COUNT(status) from listings as l where l.status=3 and l.user_id = u.Id)



4. How much revenue has each active vendor made in 2013
- Please return at least: first_name, last_name, currency, revenue
 select u.first_name,u.last_name, c.currency,sum(c.price) as revenue from users as u
   join listings as l
   on u.id = l.user_id
   join clicks c
   on c.listing_id = l.id
   group by u.first_name , u.last_name, c.currency


5. Insert a new click for listing id 3, at $4.00
- Find out the id of this new click. Please return at least: id
INSERT INTO dbo.Clicks (listing_id,price,currency,created) VALUES (3,4.00,'USD','2013-09-15 16:18:43')
select max(id) from clicks

6. Show listings that have not received a click in 2013
- Please return at least: listing_name

select l.name from listings l 
   join clicks c on l.id = c.listing_id
   where Year(c.created)  in (select Year(created) from clicks where Year(created)<>2013)


7. For each year show number of listings clicked and number of vendors who owned these listings
- Please return at least: date, total_listings_clicked, total_vendors_affected
 select c.created, count(c.listing_id) as total_listings_clicked,count(l.user_id) as total_vendors_affected from listings l 
   join users u on l.user_id= u.id
   join clicks c
   on l.id = c.listing_id
   group by c.listing_id, l.user_id, c.created

8. Return a comma separated string of listing names for all active vendors
- Please return at least: first_name, last_name, listing_names

   SELECT STRING_AGG (u.first_name, ',') AS Vendors,STRING_AGG (u.last_name, ',') AS Vendors , STRING_AGG ( l.name, ',') as listingName
FROM users u
join listings l
on u.id=l.user_id
