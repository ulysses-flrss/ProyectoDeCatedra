﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoDeCatedra
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Bolsa_Trabajo")]
	public partial class ProyectoDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    #endregion
		
		public ProyectoDataContext() : 
				base(global::ProyectoDeCatedra.Properties.Settings.Default.Bolsa_TrabajoConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ProyectoDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ProyectoDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ProyectoDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ProyectoDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.EditarCandidatos")]
		public int EditarCandidatos([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> nIdCandidato, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string sNombreCandidato, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string sNacionalidadCandidato, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string sCorreoCandidato, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Date")] System.Nullable<System.DateTime> dNacimientoUsuario, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(12)")] string sTelefonoCandidato, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Char(3)")] string sGeneroCandidato, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(20)")] string sPassword)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), nIdCandidato, sNombreCandidato, sNacionalidadCandidato, sCorreoCandidato, dNacimientoUsuario, sTelefonoCandidato, sGeneroCandidato, sPassword);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.RegistrarUsuario")]
		public int RegistrarUsuario([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> nIdUsuario, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string sNombreUsuario, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string sNacionalidadUsuario, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string sCorreoUsuario, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Date")] System.Nullable<System.DateTime> dNacimientoUsuario, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(12)")] string sTelefonoUsuario, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Char(3)")] string sGeneroUsuario, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(20)")] string sPassword, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(10)")] string nTipoUsuario)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), nIdUsuario, sNombreUsuario, sNacionalidadUsuario, sCorreoUsuario, dNacimientoUsuario, sTelefonoUsuario, sGeneroUsuario, sPassword, nTipoUsuario);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.EditarEmpleadores")]
		public int EditarEmpleadores([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> nIdEmpleador, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string sNombreEmpleador, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string sNacionalidadEmpleador, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string sCorreoEmpleador, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Date")] System.Nullable<System.DateTime> dNacimientoEmpleador, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(12)")] string sTelefonoEmpleador, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Char(3)")] string sGeneroEmpleador, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(20)")] string sPassword)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), nIdEmpleador, sNombreEmpleador, sNacionalidadEmpleador, sCorreoEmpleador, dNacimientoEmpleador, sTelefonoEmpleador, sGeneroEmpleador, sPassword);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.EditarEmpresas")]
		public int EditarEmpresas([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> nIdEmpresa, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string sNombreEmpresa, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Text")] string sDescripcion, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Char(10)")] string sTelefono, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NChar(255)")] string sDireccion, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NChar(255)")] string sCorreoEmpresa)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), nIdEmpresa, sNombreEmpresa, sDescripcion, sTelefono, sDireccion, sCorreoEmpresa);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.EditarOfertas")]
		public int EditarOfertas([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> nIdOferta, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> nIdEmpresa, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(100)")] string sTituloOferta, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Float")] System.Nullable<double> fSalario, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Date")] System.Nullable<System.DateTime> dFechaPublicacion, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Text")] string sDescipcion, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Date")] System.Nullable<System.DateTime> fechaContratacion, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> nVacantes)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), nIdOferta, nIdEmpresa, sTituloOferta, fSalario, dFechaPublicacion, sDescipcion, fechaContratacion, nVacantes);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.EditarUsuario")]
		public int EditarUsuario([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> nIdUsuario, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string sNombreUsuario, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string sNacionalidadUsuario, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string sCorreoUsuario, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Date")] System.Nullable<System.DateTime> dNacimientoUsuario, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(12)")] string sTelefonoUsuario, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Char(3)")] string sGeneroUsuario, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(20)")] string sPassword, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> nTipoUsuario)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), nIdUsuario, sNombreUsuario, sNacionalidadUsuario, sCorreoUsuario, dNacimientoUsuario, sTelefonoUsuario, sGeneroUsuario, sPassword, nTipoUsuario);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.EliminarCandidatos")]
		public int EliminarCandidatos([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> nIdCandidato)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), nIdCandidato);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.EliminarEmpleadores")]
		public int EliminarEmpleadores([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> nIdEmpleador)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), nIdEmpleador);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.EliminarEmpresas")]
		public int EliminarEmpresas([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> nIdEmpresa)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), nIdEmpresa);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.EliminarOfertas")]
		public int EliminarOfertas([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> nIdOferta)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), nIdOferta);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.EliminarUsuario")]
		public int EliminarUsuario([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> nIdUsuario)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), nIdUsuario);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ListarCandidatos")]
		public ISingleResult<ListarCandidatosResult> ListarCandidatos()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<ListarCandidatosResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ListarEmpleadores")]
		public ISingleResult<ListarEmpleadoresResult> ListarEmpleadores()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<ListarEmpleadoresResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ListarEmpresas")]
		public ISingleResult<ListarEmpresasResult> ListarEmpresas()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<ListarEmpresasResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ListarOfertas")]
		public ISingleResult<ListarOfertasResult> ListarOfertas()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<ListarOfertasResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ListarUsuarios")]
		public ISingleResult<ListarUsuariosResult> ListarUsuarios()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<ListarUsuariosResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.RegistrarCandidatos")]
		public int RegistrarCandidatos([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> nIdCandidato, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string sNombreCandidato, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string sNacionalidadCandidato, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string sCorreoCandidato, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Date")] System.Nullable<System.DateTime> dNacimientoUsuario, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(12)")] string sTelefonoCandidato, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Char(3)")] string sGeneroCandidato, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(20)")] string sPassword)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), nIdCandidato, sNombreCandidato, sNacionalidadCandidato, sCorreoCandidato, dNacimientoUsuario, sTelefonoCandidato, sGeneroCandidato, sPassword);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.RegistrarEmpleador")]
		public int RegistrarEmpleador([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> nIdEmpleador, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string sNombreEmpleador, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string sNacionalidadEmpleador, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string sCorreoEmpleador, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Date")] System.Nullable<System.DateTime> dNacimientoEmpleador, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(12)")] string sTelefonoEmpleador, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Char(3)")] string sGeneroEmpleador, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Char(50)")] string sEmpresaEmpleador, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(20)")] string sPassword)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), nIdEmpleador, sNombreEmpleador, sNacionalidadEmpleador, sCorreoEmpleador, dNacimientoEmpleador, sTelefonoEmpleador, sGeneroEmpleador, sEmpresaEmpleador, sPassword);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.RegistrarEmpresas")]
		public int RegistrarEmpresas([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> nIdEmpresa, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string sNombreEmpresa, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Text")] string sDescripcion, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Char(10)")] string sTelefono, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NChar(255)")] string sDireccion, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NChar(255)")] string sCorreoEmpresa)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), nIdEmpresa, sNombreEmpresa, sDescripcion, sTelefono, sDireccion, sCorreoEmpresa);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.usuariosID")]
		public ISingleResult<usuariosIDResult> usuariosID()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<usuariosIDResult>)(result.ReturnValue));
		}
	}
	
	public partial class ListarCandidatosResult
	{
		
		private int _nIdCandidato;
		
		private string _sNombreCandidato;
		
		private string _sNacionalidadCandidato;
		
		private string _sCorreoCandidato;
		
		private System.Nullable<System.DateTime> _dNacimientoCandidato;
		
		private string _sTelefonoCandidato;
		
		private string _sGeneroCandidato;
		
		private string _sExperienciaCandidato;
		
		private string _sPassword;
		
		public ListarCandidatosResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nIdCandidato", DbType="Int NOT NULL")]
		public int nIdCandidato
		{
			get
			{
				return this._nIdCandidato;
			}
			set
			{
				if ((this._nIdCandidato != value))
				{
					this._nIdCandidato = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sNombreCandidato", DbType="VarChar(50)")]
		public string sNombreCandidato
		{
			get
			{
				return this._sNombreCandidato;
			}
			set
			{
				if ((this._sNombreCandidato != value))
				{
					this._sNombreCandidato = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sNacionalidadCandidato", DbType="VarChar(50)")]
		public string sNacionalidadCandidato
		{
			get
			{
				return this._sNacionalidadCandidato;
			}
			set
			{
				if ((this._sNacionalidadCandidato != value))
				{
					this._sNacionalidadCandidato = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sCorreoCandidato", DbType="VarChar(50)")]
		public string sCorreoCandidato
		{
			get
			{
				return this._sCorreoCandidato;
			}
			set
			{
				if ((this._sCorreoCandidato != value))
				{
					this._sCorreoCandidato = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dNacimientoCandidato", DbType="Date")]
		public System.Nullable<System.DateTime> dNacimientoCandidato
		{
			get
			{
				return this._dNacimientoCandidato;
			}
			set
			{
				if ((this._dNacimientoCandidato != value))
				{
					this._dNacimientoCandidato = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sTelefonoCandidato", DbType="VarChar(12)")]
		public string sTelefonoCandidato
		{
			get
			{
				return this._sTelefonoCandidato;
			}
			set
			{
				if ((this._sTelefonoCandidato != value))
				{
					this._sTelefonoCandidato = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sGeneroCandidato", DbType="Char(3)")]
		public string sGeneroCandidato
		{
			get
			{
				return this._sGeneroCandidato;
			}
			set
			{
				if ((this._sGeneroCandidato != value))
				{
					this._sGeneroCandidato = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sExperienciaCandidato", DbType="VarChar(50)")]
		public string sExperienciaCandidato
		{
			get
			{
				return this._sExperienciaCandidato;
			}
			set
			{
				if ((this._sExperienciaCandidato != value))
				{
					this._sExperienciaCandidato = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sPassword", DbType="VarChar(50)")]
		public string sPassword
		{
			get
			{
				return this._sPassword;
			}
			set
			{
				if ((this._sPassword != value))
				{
					this._sPassword = value;
				}
			}
		}
	}
	
	public partial class ListarEmpleadoresResult
	{
		
		private int _nIdEmpleador;
		
		private string _sNombreEmpleador;
		
		private string _sNacionalidadEmpleador;
		
		private string _sCorreoEmpleador;
		
		private System.Nullable<System.DateTime> _dNacimientoEmpleador;
		
		private string _sTelefonoEmpleador;
		
		private string _sGeneroEmpleador;
		
		private string _sEmpresaEmpleador;
		
		private string _sPassword;
		
		public ListarEmpleadoresResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nIdEmpleador", DbType="Int NOT NULL")]
		public int nIdEmpleador
		{
			get
			{
				return this._nIdEmpleador;
			}
			set
			{
				if ((this._nIdEmpleador != value))
				{
					this._nIdEmpleador = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sNombreEmpleador", DbType="VarChar(50)")]
		public string sNombreEmpleador
		{
			get
			{
				return this._sNombreEmpleador;
			}
			set
			{
				if ((this._sNombreEmpleador != value))
				{
					this._sNombreEmpleador = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sNacionalidadEmpleador", DbType="VarChar(50)")]
		public string sNacionalidadEmpleador
		{
			get
			{
				return this._sNacionalidadEmpleador;
			}
			set
			{
				if ((this._sNacionalidadEmpleador != value))
				{
					this._sNacionalidadEmpleador = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sCorreoEmpleador", DbType="VarChar(50)")]
		public string sCorreoEmpleador
		{
			get
			{
				return this._sCorreoEmpleador;
			}
			set
			{
				if ((this._sCorreoEmpleador != value))
				{
					this._sCorreoEmpleador = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dNacimientoEmpleador", DbType="Date")]
		public System.Nullable<System.DateTime> dNacimientoEmpleador
		{
			get
			{
				return this._dNacimientoEmpleador;
			}
			set
			{
				if ((this._dNacimientoEmpleador != value))
				{
					this._dNacimientoEmpleador = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sTelefonoEmpleador", DbType="VarChar(12)")]
		public string sTelefonoEmpleador
		{
			get
			{
				return this._sTelefonoEmpleador;
			}
			set
			{
				if ((this._sTelefonoEmpleador != value))
				{
					this._sTelefonoEmpleador = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sGeneroEmpleador", DbType="Char(3)")]
		public string sGeneroEmpleador
		{
			get
			{
				return this._sGeneroEmpleador;
			}
			set
			{
				if ((this._sGeneroEmpleador != value))
				{
					this._sGeneroEmpleador = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sEmpresaEmpleador", DbType="Char(50)")]
		public string sEmpresaEmpleador
		{
			get
			{
				return this._sEmpresaEmpleador;
			}
			set
			{
				if ((this._sEmpresaEmpleador != value))
				{
					this._sEmpresaEmpleador = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sPassword", DbType="VarChar(50)")]
		public string sPassword
		{
			get
			{
				return this._sPassword;
			}
			set
			{
				if ((this._sPassword != value))
				{
					this._sPassword = value;
				}
			}
		}
	}
	
	public partial class ListarEmpresasResult
	{
		
		private int _nIdEmpresa;
		
		private string _sNombreEmpresa;
		
		private string _sDescripcion;
		
		private string _sTelefono;
		
		private string _sDireccion;
		
		private string _sCorreoEmpresa;
		
		public ListarEmpresasResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nIdEmpresa", DbType="Int NOT NULL")]
		public int nIdEmpresa
		{
			get
			{
				return this._nIdEmpresa;
			}
			set
			{
				if ((this._nIdEmpresa != value))
				{
					this._nIdEmpresa = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sNombreEmpresa", DbType="NVarChar(50)")]
		public string sNombreEmpresa
		{
			get
			{
				return this._sNombreEmpresa;
			}
			set
			{
				if ((this._sNombreEmpresa != value))
				{
					this._sNombreEmpresa = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sDescripcion", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string sDescripcion
		{
			get
			{
				return this._sDescripcion;
			}
			set
			{
				if ((this._sDescripcion != value))
				{
					this._sDescripcion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sTelefono", DbType="Char(10)")]
		public string sTelefono
		{
			get
			{
				return this._sTelefono;
			}
			set
			{
				if ((this._sTelefono != value))
				{
					this._sTelefono = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sDireccion", DbType="NChar(255)")]
		public string sDireccion
		{
			get
			{
				return this._sDireccion;
			}
			set
			{
				if ((this._sDireccion != value))
				{
					this._sDireccion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sCorreoEmpresa", DbType="NChar(255)")]
		public string sCorreoEmpresa
		{
			get
			{
				return this._sCorreoEmpresa;
			}
			set
			{
				if ((this._sCorreoEmpresa != value))
				{
					this._sCorreoEmpresa = value;
				}
			}
		}
	}
	
	public partial class ListarOfertasResult
	{
		
		private int _nIdOferta;
		
		private System.Nullable<int> _nIdEmpresa;
		
		private string _sTituloOferta;
		
		private System.Nullable<double> _fSalario;
		
		private System.Nullable<System.DateTime> _dFechaPublicacion;
		
		private string _sDescripcion;
		
		private System.Nullable<System.DateTime> _fechaContratacion;
		
		private System.Nullable<int> _nVacantes;
		
		public ListarOfertasResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nIdOferta", DbType="Int NOT NULL")]
		public int nIdOferta
		{
			get
			{
				return this._nIdOferta;
			}
			set
			{
				if ((this._nIdOferta != value))
				{
					this._nIdOferta = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nIdEmpresa", DbType="Int")]
		public System.Nullable<int> nIdEmpresa
		{
			get
			{
				return this._nIdEmpresa;
			}
			set
			{
				if ((this._nIdEmpresa != value))
				{
					this._nIdEmpresa = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sTituloOferta", DbType="NVarChar(100)")]
		public string sTituloOferta
		{
			get
			{
				return this._sTituloOferta;
			}
			set
			{
				if ((this._sTituloOferta != value))
				{
					this._sTituloOferta = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fSalario", DbType="Float")]
		public System.Nullable<double> fSalario
		{
			get
			{
				return this._fSalario;
			}
			set
			{
				if ((this._fSalario != value))
				{
					this._fSalario = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dFechaPublicacion", DbType="Date")]
		public System.Nullable<System.DateTime> dFechaPublicacion
		{
			get
			{
				return this._dFechaPublicacion;
			}
			set
			{
				if ((this._dFechaPublicacion != value))
				{
					this._dFechaPublicacion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sDescripcion", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string sDescripcion
		{
			get
			{
				return this._sDescripcion;
			}
			set
			{
				if ((this._sDescripcion != value))
				{
					this._sDescripcion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fechaContratacion", DbType="Date")]
		public System.Nullable<System.DateTime> fechaContratacion
		{
			get
			{
				return this._fechaContratacion;
			}
			set
			{
				if ((this._fechaContratacion != value))
				{
					this._fechaContratacion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nVacantes", DbType="Int")]
		public System.Nullable<int> nVacantes
		{
			get
			{
				return this._nVacantes;
			}
			set
			{
				if ((this._nVacantes != value))
				{
					this._nVacantes = value;
				}
			}
		}
	}
	
	public partial class ListarUsuariosResult
	{
		
		private int _nIdUsuario;
		
		private string _sNombreUsuario;
		
		private string _sNacionalidadUsuario;
		
		private string _sCorreoUsuario;
		
		private System.Nullable<System.DateTime> _dNacimientoUsuario;
		
		private string _sTelefonoUsuario;
		
		private string _sGeneroUsuario;
		
		private string _sPassword;
		
		private string _nTipoUsuario;
		
		public ListarUsuariosResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nIdUsuario", DbType="Int NOT NULL")]
		public int nIdUsuario
		{
			get
			{
				return this._nIdUsuario;
			}
			set
			{
				if ((this._nIdUsuario != value))
				{
					this._nIdUsuario = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sNombreUsuario", DbType="VarChar(50)")]
		public string sNombreUsuario
		{
			get
			{
				return this._sNombreUsuario;
			}
			set
			{
				if ((this._sNombreUsuario != value))
				{
					this._sNombreUsuario = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sNacionalidadUsuario", DbType="VarChar(50)")]
		public string sNacionalidadUsuario
		{
			get
			{
				return this._sNacionalidadUsuario;
			}
			set
			{
				if ((this._sNacionalidadUsuario != value))
				{
					this._sNacionalidadUsuario = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sCorreoUsuario", DbType="VarChar(50)")]
		public string sCorreoUsuario
		{
			get
			{
				return this._sCorreoUsuario;
			}
			set
			{
				if ((this._sCorreoUsuario != value))
				{
					this._sCorreoUsuario = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dNacimientoUsuario", DbType="Date")]
		public System.Nullable<System.DateTime> dNacimientoUsuario
		{
			get
			{
				return this._dNacimientoUsuario;
			}
			set
			{
				if ((this._dNacimientoUsuario != value))
				{
					this._dNacimientoUsuario = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sTelefonoUsuario", DbType="VarChar(12)")]
		public string sTelefonoUsuario
		{
			get
			{
				return this._sTelefonoUsuario;
			}
			set
			{
				if ((this._sTelefonoUsuario != value))
				{
					this._sTelefonoUsuario = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sGeneroUsuario", DbType="Char(3)")]
		public string sGeneroUsuario
		{
			get
			{
				return this._sGeneroUsuario;
			}
			set
			{
				if ((this._sGeneroUsuario != value))
				{
					this._sGeneroUsuario = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sPassword", DbType="VarChar(20)")]
		public string sPassword
		{
			get
			{
				return this._sPassword;
			}
			set
			{
				if ((this._sPassword != value))
				{
					this._sPassword = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nTipoUsuario", DbType="VarChar(10)")]
		public string nTipoUsuario
		{
			get
			{
				return this._nTipoUsuario;
			}
			set
			{
				if ((this._nTipoUsuario != value))
				{
					this._nTipoUsuario = value;
				}
			}
		}
	}
	
	public partial class usuariosIDResult
	{
		
		private int _nIdUsuario;
		
		public usuariosIDResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nIdUsuario", DbType="Int NOT NULL")]
		public int nIdUsuario
		{
			get
			{
				return this._nIdUsuario;
			}
			set
			{
				if ((this._nIdUsuario != value))
				{
					this._nIdUsuario = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
