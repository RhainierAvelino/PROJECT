SELECT COUNT(*) FROM orders WHERE order_date >= DATEADD(day, -30, GETDATE());
SELECT * FROM orders WHERE prod_name IS NULL;
SELECT customer_id, order_date, STRING_AGG(prod_name, ',') 
FROM orders
GROUP BY customer_id, order_date
DELETE FROM orders;
INSERT INTO orders (customer_id, prod_id, prod_name, category, orig_price, quantity, total_price, order_date)
VALUES 
-- Milk + Bread combo (repeat 4x)
(1, 'P001', 'Milk', 'Grocery', 50, 1, 50, GETDATE() - 1),
(1, 'P002', 'Bread', 'Grocery', 20, 1, 20, GETDATE() - 1),

(2, 'P001', 'Milk', 'Grocery', 50, 1, 50, GETDATE() - 2),
(2, 'P002', 'Bread', 'Grocery', 20, 1, 20, GETDATE() - 2),

(3, 'P001', 'Milk', 'Grocery', 50, 1, 50, GETDATE() - 3),
(3, 'P002', 'Bread', 'Grocery', 20, 1, 20, GETDATE() - 3),

(4, 'P001', 'Milk', 'Grocery', 50, 1, 50, GETDATE() - 4),
(4, 'P002', 'Bread', 'Grocery', 20, 1, 20, GETDATE() - 4),

-- Shampoo + Conditioner combo (repeat 3x)
(5, 'P010', 'Shampoo', 'Toiletries', 100, 1, 100, GETDATE() - 5),
(5, 'P011', 'Conditioner', 'Toiletries', 90, 1, 90, GETDATE() - 5),

(6, 'P010', 'Shampoo', 'Toiletries', 100, 1, 100, GETDATE() - 6),
(6, 'P011', 'Conditioner', 'Toiletries', 90, 1, 90, GETDATE() - 6),

(7, 'P010', 'Shampoo', 'Toiletries', 100, 1, 100, GETDATE() - 7),
(7, 'P011', 'Conditioner', 'Toiletries', 90, 1, 90, GETDATE() - 7),

-- Coffee + Creamer combo (repeat 4x)
(8, 'P020', 'Coffee', 'Beverages', 120, 1, 120, GETDATE() - 2),
(8, 'P021', 'Creamer', 'Beverages', 60, 1, 60, GETDATE() - 2),

(9, 'P020', 'Coffee', 'Beverages', 120, 1, 120, GETDATE() - 3),
(9, 'P021', 'Creamer', 'Beverages', 60, 1, 60, GETDATE() - 3),

(10, 'P020', 'Coffee', 'Beverages', 120, 1, 120, GETDATE() - 4),
(10, 'P021', 'Creamer', 'Beverages', 60, 1, 60, GETDATE() - 4),

(11, 'P020', 'Coffee', 'Beverages', 120, 1, 120, GETDATE() - 5),
(11, 'P021', 'Creamer', 'Beverages', 60, 1, 60, GETDATE() - 5);
-- Rice + Sardines combo (repeat 4x)
INSERT INTO orders (customer_id, prod_id, prod_name, category, orig_price, quantity, total_price, order_date)
VALUES
(12, 'P030', 'Rice', 'Grocery', 45, 1, 45, GETDATE() - 1),
(12, 'P031', 'Sardines', 'Grocery', 25, 2, 50, GETDATE() - 1),

(13, 'P030', 'Rice', 'Grocery', 45, 1, 45, GETDATE() - 2),
(13, 'P031', 'Sardines', 'Grocery', 25, 1, 25, GETDATE() - 2),

(14, 'P030', 'Rice', 'Grocery', 45, 1, 45, GETDATE() - 3),
(14, 'P031', 'Sardines', 'Grocery', 25, 2, 50, GETDATE() - 3),

(15, 'P030', 'Rice', 'Grocery', 45, 1, 45, GETDATE() - 4),
(15, 'P031', 'Sardines', 'Grocery', 25, 1, 25, GETDATE() - 4),

-- Soap + Toothpaste (repeat 3x)
(16, 'P040', 'Soap', 'Toiletries', 30, 1, 30, GETDATE() - 1),
(16, 'P041', 'Toothpaste', 'Toiletries', 40, 1, 40, GETDATE() - 1),

(17, 'P040', 'Soap', 'Toiletries', 30, 1, 30, GETDATE() - 2),
(17, 'P041', 'Toothpaste', 'Toiletries', 40, 1, 40, GETDATE() - 2),

(18, 'P040', 'Soap', 'Toiletries', 30, 1, 30, GETDATE() - 3),
(18, 'P041', 'Toothpaste', 'Toiletries', 40, 1, 40, GETDATE() - 3),

-- Add some mix-match combos to create noise
(19, 'P001', 'Milk', 'Grocery', 50, 1, 50, GETDATE() - 5),
(19, 'P020', 'Coffee', 'Beverages', 120, 1, 120, GETDATE() - 5),

(20, 'P002', 'Bread', 'Grocery', 20, 1, 20, GETDATE() - 6),
(20, 'P011', 'Conditioner', 'Toiletries', 90, 1, 90, GETDATE() - 6),

(21, 'P010', 'Shampoo', 'Toiletries', 100, 1, 100, GETDATE() - 4),
(21, 'P030', 'Rice', 'Grocery', 45, 1, 45, GETDATE() - 4),

(22, 'P020', 'Coffee', 'Beverages', 120, 1, 120, GETDATE() - 3),
(22, 'P040', 'Soap', 'Toiletries', 30, 1, 30, GETDATE() - 3),

(23, 'P031', 'Sardines', 'Grocery', 25, 1, 25, GETDATE() - 2),
(23, 'P002', 'Bread', 'Grocery', 20, 1, 20, GETDATE() - 2);

select * from orders


INSERT INTO orders (customer_id, prod_id, prod_name, category, orig_price, quantity, total_price, order_date)
VALUES
(24, 'P020', 'Coffee', 'Beverages', 120, 1, 120, GETDATE() - 1),
(24, 'P021', 'Creamer', 'Beverages', 60, 1, 60, GETDATE() - 1),
(24, 'P002', 'Bread', 'Grocery', 20, 1, 20, GETDATE() - 1),

(25, 'P020', 'Coffee', 'Beverages', 120, 1, 120, GETDATE() - 2),
(25, 'P021', 'Creamer', 'Beverages', 60, 1, 60, GETDATE() - 2),
(25, 'P002', 'Bread', 'Grocery', 20, 1, 20, GETDATE() - 2),

(26, 'P020', 'Coffee', 'Beverages', 120, 1, 120, GETDATE() - 3),
(26, 'P021', 'Creamer', 'Beverages', 60, 1, 60, GETDATE() - 3),
(26, 'P002', 'Bread', 'Grocery', 20, 1, 20, GETDATE() - 3),

-- New dominating pair: Eggs + Hotdog (repeat 5x)
(27, 'P050', 'Eggs', 'Grocery', 80, 1, 80, GETDATE() - 1),
(27, 'P051', 'Hotdog', 'Grocery', 100, 1, 100, GETDATE() - 1),

(28, 'P050', 'Eggs', 'Grocery', 80, 1, 80, GETDATE() - 2),
(28, 'P051', 'Hotdog', 'Grocery', 100, 1, 100, GETDATE() - 2),

(29, 'P050', 'Eggs', 'Grocery', 80, 1, 80, GETDATE() - 3),
(29, 'P051', 'Hotdog', 'Grocery', 100, 1, 100, GETDATE() - 3),

(30, 'P050', 'Eggs', 'Grocery', 80, 1, 80, GETDATE() - 4),
(30, 'P051', 'Hotdog', 'Grocery', 100, 1, 100, GETDATE() - 4),

(31, 'P050', 'Eggs', 'Grocery', 80, 1, 80, GETDATE() - 5),
(31, 'P051', 'Hotdog', 'Grocery', 100, 1, 100, GETDATE() - 5),

-- Noise combos (1-offs to confuse confidence)
(32, 'P041', 'Toothpaste', 'Toiletries', 40, 1, 40, GETDATE() - 2),
(32, 'P051', 'Hotdog', 'Grocery', 100, 1, 100, GETDATE() - 2),

(33, 'P030', 'Rice', 'Grocery', 45, 1, 45, GETDATE() - 3),
(33, 'P021', 'Creamer', 'Beverages', 60, 1, 60, GETDATE() - 3),

(34, 'P001', 'Milk', 'Grocery', 50, 1, 50, GETDATE() - 4),
(34, 'P010', 'Shampoo', 'Toiletries', 100, 1, 100, GETDATE() - 4);