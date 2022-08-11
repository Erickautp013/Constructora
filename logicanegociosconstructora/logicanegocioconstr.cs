using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Entidadesconstructora;
using Accesodatosconstructora;


namespace logicanegociosconstructora
{
    public class logicanegocioconstr
    {
        private AccesoSQL operacion = null;
        public logicanegocioconstr (string cadconexion)
        {
            operacion = new AccesoSQL(cadconexion);
        }

        public string MiMessageBox(string titulo, string msg, short tip)
        {
            string icono = "";
            switch (tip)
            {
                case 1:
                    icono = "'info'";
                    break;
                case 2:
                    icono = "'success'";
                    break;
                case 3:
                    icono = "'error'";
                    break;
                case 4:
                    icono = "'question'";
                    break;
            }
            string functionjs = "Mensaje('" + titulo + "','" + msg + "'," + icono + ");";
            return functionjs;
        }

        //Insertar, mostrar y atualiza material
        public Boolean InsertarMaterial(int ID_Material, string Descripcion_Mat, string Marca, string Presentacion, int ID_Tipo, ref string m)
        {
            string sentencia = "insert into Material(ID_Material,Descripcion_Mat,Marca,Presentacion,ID_Tipo) " +
                "values (@ID_Material,@Descripcion_Mat,@Marca,@Presentacion,@ID_Tipo);";
            SqlParameter[] coleccion = new SqlParameter[]
            {

                new SqlParameter("ID_Material",SqlDbType.Int),
                new SqlParameter("Descripcion_Mat",SqlDbType.VarChar,60),
                new SqlParameter("Marca",SqlDbType.VarChar,40),
                new SqlParameter("Presentacion",SqlDbType.VarChar,60),
                new SqlParameter("ID_Tipo",SqlDbType.Int)


            };
            coleccion[0].Value = ID_Material;
            coleccion[1].Value = Descripcion_Mat;
            coleccion[2].Value = Marca;
            coleccion[3].Value = Presentacion;
            coleccion[4].Value = ID_Tipo;

            Boolean salida = false;
            operacion.ModificarBDMasseguro(sentencia, operacion.Abrirconexion(ref m), ref m, coleccion);
            return salida;
        }

        public DataTable obtenMaterial(ref string mensaje)
        {
            string consulta = "select * from Material;";
            DataSet obtener = null;
            DataTable salida = null;
            obtener = operacion.ConsultaDataSet(consulta, operacion.Abrirconexion(ref mensaje), ref mensaje);

            if (obtener != null)
            {
                salida = obtener.Tables[0];
            }
            return salida;
        }

        public Boolean ActualizarMaterial(string Descripcion_Mat, int ID_Tipo, ref string m)
        {
            string sentencia = "Update Material Set Descripcion_Mat =  " + " '" + Descripcion_Mat + "'" + "  where  ID_Tipo = " + ID_Tipo;
            SqlParameter[] coleccion = new SqlParameter[]
            {


                new SqlParameter("Descricion_Mat",SqlDbType.VarChar,250),
                new SqlParameter("ID_Tipo",SqlDbType.Int)

            };
            coleccion[0].Value = Descripcion_Mat;
            coleccion[1].Value = ID_Tipo;

            Boolean salida = false;
            operacion.ModificarBDMasseguro(sentencia, operacion.Abrirconexion(ref m), ref m, coleccion);
            return salida;
        }

        //Insertar,mostrar y actualizar Obra
        public Boolean InsertarObra(int ID_Obra, string Nom_Obra, string Direccion, DateTime Fecha_Inicio, DateTime Fecha_Termino, int ID_Dueno, int ID_Encargado, ref string m)
        {
            string sentencia = "insert into Obra(ID_Obra,Nom_Obra,Direccion,Fecha_Inicio,Fecha_Termino, ID_Dueno, ID_Encargado) " +
                "values (@ID_Obra,@Nom_Obra,@Direccion,@Fecha_Inicio,@Fecha_Termino, @ID_Dueno, @ID_Encargado);";
            SqlParameter[] coleccion = new SqlParameter[]
            {

                new SqlParameter("ID_Obra",SqlDbType.Int),
                new SqlParameter("Nom_Obra",SqlDbType.VarChar,40),
                new SqlParameter("Direccion",SqlDbType.VarChar,60),
                new SqlParameter("Fecha_Inicio",SqlDbType.DateTime),
                new SqlParameter("Fecha_termino",SqlDbType.DateTime),
                new SqlParameter("ID_Dueno",SqlDbType.Int),
                new SqlParameter("ID_Encargado",SqlDbType.Int)


            };
            coleccion[0].Value = ID_Obra;
            coleccion[1].Value = Nom_Obra;
            coleccion[2].Value = Direccion;
            coleccion[3].Value = Fecha_Inicio;
            coleccion[4].Value = Fecha_Termino;
            coleccion[5].Value = ID_Dueno;
            coleccion[6].Value = ID_Encargado;


            Boolean salida = false;
            operacion.ModificarBDMasseguro(sentencia, operacion.Abrirconexion(ref m), ref m, coleccion);
            return salida;
        }

        public DataTable obtenObra(ref string mensaje)
        {
            string consulta = "select * from Obra;";
            DataSet obtener = null;
            DataTable salida = null;
            obtener = operacion.ConsultaDataSet(consulta, operacion.Abrirconexion(ref mensaje), ref mensaje);

            if (obtener != null)
            {
                salida = obtener.Tables[0];
            }
            return salida;
        }

        public Boolean ActualizarObra(string Direccion, int ID_Dueno, ref string m)
        {
            string sentencia = "Update Obra Set Direccion =  " + " '" + Direccion + "'" + "  where  ID_Dueno = " + ID_Dueno;
            SqlParameter[] coleccion = new SqlParameter[]
            {


                new SqlParameter("Direccion",SqlDbType.VarChar,250),
                new SqlParameter("ID_Dueno",SqlDbType.Int)

            };
            coleccion[0].Value = Direccion;
            coleccion[1].Value = ID_Dueno;

            Boolean salida = false;
            operacion.ModificarBDMasseguro(sentencia, operacion.Abrirconexion(ref m), ref m, coleccion);
            return salida;
        }

        //Insertar,mostrar y actualizar Provedoramaterial
        public Boolean InsertarProvee_De_Materi_Obra(string Recibio, string Entrega, int Cantidad, DateTime Fecha_Entre, float Precio, int ID_Obra, int ID_Material, int ID_Proveedor,ref string m)
        {
            string sentencia = "insert into Provee_De_Materi_Obra(Recibio,Entrega,Cantidad,Fecha_Entre,Precio,ID_Obra,ID_Material, ID_Proveedor) " +
                "values (@Recibio,@Entrega,@Cantidad,@Fecha_Entre,@Precio, @ID_Obra, @ID_Material,@ID_Proveedor);";
            SqlParameter[] coleccion = new SqlParameter[]
            {

                new SqlParameter("Recibio",SqlDbType.VarChar,30),
                new SqlParameter("Entrega",SqlDbType.VarChar,30),
                new SqlParameter("Cantidad",SqlDbType.Int),
                new SqlParameter("Fecha_Entre",SqlDbType.DateTime),
                new SqlParameter("Precio",SqlDbType.Float),
                new SqlParameter("ID_Obra",SqlDbType.Int),
                new SqlParameter("ID_Material",SqlDbType.Int),
                new SqlParameter("ID_Proveedor",SqlDbType.Int)


            };
            coleccion[0].Value = Recibio;
            coleccion[1].Value = Entrega;
            coleccion[2].Value = Cantidad;
            coleccion[3].Value = Fecha_Entre;
            coleccion[4].Value = Precio;
            coleccion[5].Value = ID_Obra;
            coleccion[6].Value = ID_Material;
            coleccion[6].Value = ID_Proveedor;


            Boolean salida = false;
            operacion.ModificarBDMasseguro(sentencia, operacion.Abrirconexion(ref m), ref m, coleccion);
            return salida;
        }

        public DataTable obtenProvee_De_Materi_Obra(ref string mensaje)
        {
            string consulta = "select * from Provee_De_Materi_Obra;";
            DataSet obtener = null;
            DataTable salida = null;
            obtener = operacion.ConsultaDataSet(consulta, operacion.Abrirconexion(ref mensaje), ref mensaje);

            if (obtener != null)
            {
                salida = obtener.Tables[0];
            }
            return salida;
        }

        public Boolean ActualizarProvee_De_Materi_Obra(string Entrega, int ID_Obra, ref string m)
        {
            string sentencia = "Update Obra Set Entrega =  " + " '" + Entrega + "'" + "  where  ID_Obra = " + ID_Obra;
            SqlParameter[] coleccion = new SqlParameter[]
            {


                new SqlParameter("Entrega",SqlDbType.VarChar,250),
                new SqlParameter("ID_Obra",SqlDbType.Int)

            };
            coleccion[0].Value = Entrega;
            coleccion[1].Value = ID_Obra;

            Boolean salida = false;
            operacion.ModificarBDMasseguro(sentencia, operacion.Abrirconexion(ref m), ref m, coleccion);
            return salida;
        }

        //consulta especifica
        public DataTable dueno_obras(string ID_Dueno, ref string mensaje)
        {
            string consulta = "execute dueno_obra" + ID_Dueno;
            DataSet obtener = null;
            DataTable salida = null;
            obtener = operacion.ConsultaDataSet(consulta, operacion.Abrirconexion(ref mensaje), ref mensaje);

            if (obtener != null)
            {
                salida = obtener.Tables[0];
            }
            return salida;
        }
    }
        

    }

