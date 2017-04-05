
SELECT film.`film_id`,film.`title`,inventory.`inventory_id`
FROM film 
LEFT JOIN inventory ON film.film_id=inventory.film_id;

SELECT film.`film_id`,film.`title`,customer.`first_name`,customer.`first_name`, customer.`customer_id`
FROM film 
LEFT JOIN inventory ON film.film_id=inventory.film_id;

SELECT film.`film_id`,film.`title`,inventory.`inventory_id`
FROM film 
LEFT JOIN inventory ON film.film_id=inventory.film_id;

SELECT customer.`customer_id`,customer.`first_name`,customer.`last_name`,rental.`rental_id`,rental.`return_date`,inventory.`film_id`,film.`title`
FROM customer
JOIN rental ON customer.`customer_id`=rental.`customer_id`
JOIN inventory ON rental.`inventory`sakila`_id`=inventory.`inventory_id`
JOIN film ON inventory.`film_id`=film.`film_id`;

SELECT film.`film_id`,film.`title`,inventory.`inventory_id`
FROM film 
LEFT JOIN inventory ON film.film_id=inventory.film_id;

SELECT category.`category_id`,category.`name` FROM category;

SELECT film.`title`,film.`description`,category.`name`,film.`release_year`,film.`length`,film.`rental_duration`,film.`rental_rate`,film.`special_features`,film.`replacement_cost` FROM film
LEFT JOIN film_category ON film.`film_id`=film_category.`film_id`
LEFT JOIN category ON film_category.`category_id`=category.`category_id`;
--WHERE category.`category_id`=1; 

SELECT actor.`first_name`,actor.`last_name`
FROM actor
LEFT JOIN film_actor ON actor.`actor_id`=film_actor.`actor_id`
LEFT JOIN film ON film_actor.`film_id`=film.`film_id`
WHERE film.`title`='ACADEMY DINOSAUR';

SELECT payment.`rental_id`,rental.`rental_date`
FROM rental
LEFT JOIN payment ON rental.`rental_id`=payment.`rental_id`
WHERE payment.`rental_id` IS NULL;

 SELECT
  customer.`customer_id` AS ID,
  CONCAT(customer.`first_name`,_utf8' ',customer.`last_name`) AS `Full Name`,
  customer.`email` AS `E-Mail`,
  address.`address` AS `Address`,
  address.`postal_code` AS `Zip Code`,
  address.`phone` AS `Phone`,
  city.`city` AS City,
  country.`country` AS Country,
  IF(customer.`active`,_utf8'active',_utf8'') AS `Notes`,
  customer.`store_id` AS SID
  FROM customer 
  JOIN address ON customer.`address_id`=address.`address_id`
  JOIN city ON address.`city_id`=city.`city_id`
  JOIN country ON city.`country_id`=country.`country_id`;
  
   SELECT
  `film`.`film_id`     AS `FID`,
  `film`.`title`       AS `title`,
  `film`.`description` AS `description`,
  `category`.`name`    AS `category`,
  `film`.`rental_rate` AS `price`,
  `film`.`length`      AS `length`,
  `film`.`rating`      AS `rating`,
  film.`special_features` AS special_features,
  film.`rental_duration` AS rental_duration,
  film.`replacement_cost`AS replacement_cost
  FROM category
  LEFT JOIN film_category ON category.`category_id`=film_category.`category_id`
  LEFT JOIN film ON film_category.`film_id`=film.`film_id`;
 