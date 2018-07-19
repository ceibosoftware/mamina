using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Product
    {
    
        CRUD conexion = new CRUD();
        private int id;
        private String code;
        private String name;
        private decimal salePrice;
        private decimal costPrice;
        private int minStock;
        private int stock;
        private String image;
        private int quantity;
        private int  idCategoria;


        public void Save()
        {
            String insert = "INSERT INTO product (name, costPrice,salePrice ,minStock,stock, quantity, category, image, code)VALUES ('"+name+ "','" + costPrice + "','" + salePrice+ "','" + minStock + "','" + stock + "','" + quantity + "','" + idCategoria + "','" + image + "','" + code + "')";
            conexion.operaciones(insert);
        }

        public void Update()
        {
            String update = "UPDATE product SET name = '" + name + "', costPrice ='"+costPrice+ "', salePrice ='" + salePrice + "', minStock ='" + minStock + "', stock ='" + stock + "', quantity ='" + quantity + "', quantity ='" + quantity + "', FK_idCategory ='" + idCategoria + "', image ='" + image + "', code ='" + code + "' where idProduct = '" + id + "'";
            conexion.operaciones(update);
        }

        public void Delete()
        {
            string delete = " DELETE  FROM product WHERE idProduct =  '" + id+ "'";
            conexion.operaciones(delete);
        }
    }
}
