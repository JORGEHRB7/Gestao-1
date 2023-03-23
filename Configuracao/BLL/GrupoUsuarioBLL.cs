using DAL;
using Models;
using System;
using System.Data.SqlClient;

namespace BLL
{
    public class GrupoUsuarioBLL
    {
        public void Inserir(GrupoUsuario _grupousuario)
        {
            if (_grupousuario.NomeGrupo.Length <= 3 || _grupousuario.NomeGrupo.Length >= 150)
                throw new Exception("O nome do grupo deverá conter de 3 a 150 caracteres.");

            GrupoUsuarioDAL grupoUsuarioDAL = new GrupoUsuarioDAL();
            grupoUsuarioDAL.Inserir(_grupoUsuario);
        }
        public GrupoUsuario Buscar(GrupoUsuario _grupoUsuario)
        {
            GrupoUsuarioDAL grupoUsuarioDAL = new GrupoUsuarioDAL();
            grupoUsuarioDAL.BuscarPorUsuario(_grupoUsuario);

            return GrupoUsuarioDAL.BuscarPorUsuario(_grupoUsuario);
        }
        public void Alterar(GrupoUsuario _grupoUsuario)
        {
            if (_grupoUsuario.NomeGrupo.Length <= 3 || _grupoUsuario.NomeGrupo.Length >= 150)
                throw new Exception("O nome do grupo deverá conter de 3 a 150 caracteres.");

            GrupoUsuarioDAL grupoUsuarioDAL = new GrupoUsuarioDAL();
            GrupoUsuarioDAL.Alterar(_grupoUsuario);
        }
        public void Excluir(GrupoUsuario _grupoUsuario)
        {
            GrupoUsuarioDAL grupoUsuarioDAL = new GrupoUsuarioDAL();
            GrupoUsuarioDAL.Excluir(_grupoUsuario);
        }
    }
}