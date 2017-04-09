UPDATE payment SET payment_date=DATE_ADD(payment_date, INTERVAL 11 YEAR);
UPDATE rental SET rental_date=DATE_ADD(rental_date, INTERVAL 11 YEAR), rental.`return_date`=DATE_ADD(rental.`return_date`, INTERVAL 11 YEAR);
SELECT * FROM rental;
SELECT * FROM payment;