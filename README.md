# MindBoxTest
## Задание 2
**Создание таблицы:**
```
CREATE TABLE products (
    product_id INT PRIMARY KEY IDENTITY,
    product_name NVARCHAR(255) NOT NULL
);

CREATE TABLE categories (
    category_id INT PRIMARY KEY IDENTITY,
    category_name NVARCHAR(255) NOT NULL
);

CREATE TABLE product_categories (
    product_id INT,
    category_id INT,
    PRIMARY KEY (product_id, category_id),
    FOREIGN KEY (product_id) REFERENCES products(product_id),
    FOREIGN KEY (category_id) REFERENCES categories(category_id)
);
```
**Заполнение таблиц**
```
INSERT INTO products (product_name) VALUES 
('The Witcher 3: Wild Hunt'),
('Cyberpunk 2077'),
('Red Dead Redemption 2'),
('Minecraft'),
('Among Us'),
('GTA V'),
('Fortnite'),
('The Sims 4'),
('League of Legends'),
('Overwatch 2'),
('Stardew Valley');

INSERT INTO categories (category_name) VALUES 
('RPG'),
('Action'),
('Adventure'),
('Sandbox'),
('Multiplayer'),
('Shooter'),
('Simulation'),
('Strategy'),
('Battle Royale');

-- Заполнение таблицы product_categories (связь игр с категориями)
INSERT INTO product_categories (product_id, category_id) VALUES 
(1, 1), 
(1, 2), 
(2, 1), 
(2, 2), 
(3, 2), 
(3, 3), 
(4, 4), 
(4, 5), 
(5, 5), 
(6, 2), 
(6, 3), 
(7, 9), 
(8, 7), 
(9, 5), 
(9, 2), 
(10, 6); 
```
**Запрос**
```
SELECT 
    p.product_name AS ProductName,
    c.category_name AS CategoryName
FROM 
    products p
LEFT JOIN 
    product_categories pc ON p.product_id = pc.product_id
LEFT JOIN 
    categories c ON pc.category_id = c.category_id
ORDER BY 
    p.product_name, c.category_name;
```
**Результат (CSV)**
Among Us;Multiplayer
Cyberpunk 2077;Action
Cyberpunk 2077;RPG
Fortnite;Battle Royale
GTA V;Action
GTA V;Adventure
League of Legends;Action
League of Legends;Multiplayer
Minecraft;Multiplayer
Minecraft;Sandbox
Overwatch 2;Shooter
Red Dead Redemption 2;Action
Red Dead Redemption 2;Adventure
Stardew Valley;NULL
The Sims 4;Simulation
The Witcher 3: Wild Hunt;Action
The Witcher 3: Wild Hunt;RPG
