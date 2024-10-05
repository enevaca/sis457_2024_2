using CadMinerva;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnMinerva
{
    public class EmpleadoCln
    {
        public static int insertar(Empleado empleado, Usuario usuario)
        {
            using (var context = new MinervaEntities())
            {
                context.Empleado.Add(empleado);
                context.SaveChanges();

                if (usuario != null)
                {
                    usuario.idEmpleado = empleado.id;
                    context.Usuario.Add(usuario);
                    context.SaveChanges();
                }

                return empleado.id;
            }
        }

        public static int actualizar(Empleado empleado)
        {
            using (var context = new MinervaEntities())
            {
                var existente = context.Empleado.Find(empleado.id);
                existente.cedulaIdentidad = empleado.cedulaIdentidad;
                existente.nombres = empleado.nombres;
                existente.primerApellido = empleado.primerApellido;
                existente.segundoApellido = empleado.segundoApellido;
                existente.direccion = empleado.direccion;
                existente.celular = empleado.celular;
                existente.cargo = empleado.cargo;
                existente.usuarioRegistro = empleado.usuarioRegistro;
                return context.SaveChanges();
            }
        }

        public static int eliminar(int id, string usuario)
        {
            using (var context = new MinervaEntities())
            {
                var empleado = context.Empleado.Find(id);
                empleado.estado = -1;
                empleado.usuarioRegistro = usuario;
                return context.SaveChanges();
            }
        }

        public static Empleado obtenerUno(int id)
        {
            using (var context = new MinervaEntities())
            {
                var empleado = context.Empleado.Find(id);
                empleado.Usuario = context.Usuario.Where(x => x.idEmpleado == id).ToList();
                return empleado;
            }
        }

        public static List<Empleado> listar()
        {
            using (var context = new MinervaEntities())
            {
                return context.Empleado.Where(x => x.estado != -1).ToList();
            }
        }

        public static List<paEmpleadoListar_Result> listarPa(string parametro)
        {
            using (var context = new MinervaEntities())
            {
                return context.paEmpleadoListar(parametro).ToList();
            }
        }
    }
}
