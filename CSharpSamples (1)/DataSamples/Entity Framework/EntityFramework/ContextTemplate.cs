﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Data.EntityClient;
using System.Data.Objects;
using System.Diagnostics.CodeAnalysis;
using EmployeeTracker.Common;
using EmployeeTracker.Model;

namespace EmployeeTracker.EntityFramework
{
    #region Contexts
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [SuppressMessage("Microsoft.Design", "CA1063:ImplementIDisposableCorrectly", Justification = "IDisposable is specified by IEmployeeContext and the implementation is inherited from ObjectContext")]
    public partial class EmployeeEntities : ObjectContext, IEmployeeContext
    {
        #region Constructors
        /// <summary>
        /// Initializes a new EmployeeEntities object using the connection string found in the 'EmployeeEntities' section of the application configuration file.
        /// </summary>
        public EmployeeEntities() : base("name=EmployeeEntities", "EmployeeEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new EmployeeEntities object.
        /// </summary>
        public EmployeeEntities(string connectionString) : base(connectionString, "EmployeeEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new EmployeeEntities object.
        /// </summary>
        public EmployeeEntities(EntityConnection connection) : base(connection, "EmployeeEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
        #endregion
    	
        #region Partial Methods
        partial void OnContextCreated();
        #endregion
    	
        #region IEmployeeContext
    	
    	/// <summary>
        /// Save all pending changes to the data context
        /// </summary>
        public void Save()
        {
            this.SaveChanges();
        }
    	
    	/// <summary>
        /// Checks if the supplied object is tracked in this data context
        /// </summary>
        /// <param name="obj">The object to check for</param>
        /// <returns>True if the object is tracked, false otherwise</returns>
        public bool IsObjectTracked(object entity)
        {
            ObjectStateEntry ose;
            return this.ObjectStateManager.TryGetObjectStateEntry(entity, out ose);
        }
    	
        #endregion
        
        #region ObjectSet Properties
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public IObjectSet<ContactDetail> ContactDetails
        {
            get
            {
                if ((_ContactDetails == null))
                {
                    _ContactDetails = base.CreateObjectSet<ContactDetail>("ContactDetails");
                }
                return _ContactDetails;
            }
        }
        private ObjectSet<ContactDetail> _ContactDetails;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public IObjectSet<Department> Departments
        {
            get
            {
                if ((_Departments == null))
                {
                    _Departments = base.CreateObjectSet<Department>("Departments");
                }
                return _Departments;
            }
        }
        private ObjectSet<Department> _Departments;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public IObjectSet<Employee> Employees
        {
            get
            {
                if ((_Employees == null))
                {
                    _Employees = base.CreateObjectSet<Employee>("Employees");
                }
                return _Employees;
            }
        }
        private ObjectSet<Employee> _Employees;
    
        #endregion
        #region AddTo Methods
            
        /// <summary>
        /// Deprecated Method for adding a new object to the ContactDetails EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToContactDetails(ContactDetail contactDetail)
        {
            base.AddObject("ContactDetails", contactDetail);
        }
            
        /// <summary>
        /// Deprecated Method for adding a new object to the Departments EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToDepartments(Department department)
        {
            base.AddObject("Departments", department);
        }
            
        /// <summary>
        /// Deprecated Method for adding a new object to the Employees EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToEmployees(Employee employee)
        {
            base.AddObject("Employees", employee);
        }
        #endregion
    }
    
    #endregion
}
