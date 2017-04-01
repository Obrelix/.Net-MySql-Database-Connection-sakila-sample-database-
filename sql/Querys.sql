
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
JOIN film_category ON film.`film_id`=film_category.`film_id`
JOIN category ON film_category.`category_id`=category.`category_id`
WHERE category.`category_id`=1; 

SELECT actor.`first_name`,actor.`last_name`
FROM actor
JOIN film_actor ON actor.`actor_id`=film_actor.`actor_id`
JOIN film ON film_actor.`film_id`=film.`film_id`
WHERE film.`title`='ACADEMY DINOSAUR';