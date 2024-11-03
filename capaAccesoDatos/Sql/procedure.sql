create procedure listarClientes
as
begin
	select * from customers where estado = 1
end

execute listarClientes


CREATE PROCEDURE agregarCliente
    @nombre VARCHAR(50),
    @correo VARCHAR(100),
    @telefono VARCHAR(15),
    @estado BIT -- 1 o 0
AS
BEGIN
    INSERT INTO customers (name, email, phone, estado)
    VALUES (@nombre, @correo, @telefono, @estado);
END;


create procedure deshabilitarCliente
	@id int
as
begin
	update customers set estado = 0 where id = @id
end


CREATE PROCEDURE editarCliente
	@id int,
    @nombre VARCHAR(50),
    @correo VARCHAR(100),
    @telefono VARCHAR(15),
    @estado BIT -- 1 o 0
AS
BEGIN
	update customers set name = @nombre, email = @correo, phone = @telefono, estado = @estado
	where id = @id
END;

select * from products
CREATE PROCEDURE agregarProducto
    @nombre VARCHAR(50),
    @descripcion VARCHAR(100),
    @precio VARCHAR(15),
    @estado BIT -- 1 o 0
AS
BEGIN
    INSERT INTO products(name, description, price, estado)
    VALUES (@nombre, @descripcion, @precio, @estado);
END;



create or alter procedure listarProductos
as
begin
	select * from products where estado = 1
end

select * from products

execute listarProductos


create procedure listarOrdenes
as
begin
	select * from orders where estado = 1
end


CREATE PROCEDURE agregarCompra
    @idCliente INT,
    @fecha DATE,
    @estado BIT
AS
BEGIN
    INSERT INTO orders (customer_id, order_date, estado)
    VALUES (@idCliente, @fecha, @estado);
END;


CREATE PROCEDURE ultimaCompra
AS
BEGIN
    SELECT TOP 1 id 
    FROM orders 
    ORDER BY id DESC; 
END;


select * from order_items

create procedure agregarItem
@compraId int,
@productoId int,
@cantidad int,
@precioTotal float
as
begin
	insert into order_items (order_id, product_id, quantity , total_price) values(@compraId, @productoId, @cantidad, @precioTotal)
end

create procedure deshabilitarCompra
@idCompra int
as 
begin
	update orders set estado = 0 where id = @idCompra
end