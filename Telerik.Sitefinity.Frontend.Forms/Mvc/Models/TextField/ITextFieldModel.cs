﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.UI;
using Telerik.Sitefinity.Metadata.Model;
using Telerik.Sitefinity.Modules.Forms.Web.UI.Fields;
using Telerik.Sitefinity.Web.UI.Validation.Definitions;

namespace Telerik.Sitefinity.Frontend.Forms.Mvc.Models.TextField
{
    public interface ITextFieldModel
    {
        /// <summary>
        /// Gets or sets the value of the form field.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        object Value { get; set; }

        /// <summary>
        /// Gets or sets the validation attributes.
        /// </summary>
        /// <value>
        /// The validation attributes.
        /// </value>
        MvcHtmlString ValidationAttributes { get; }

        /// <summary>
        /// Gets or sets the placeholder text.
        /// </summary>
        /// <value>
        /// The placeholder text.
        /// </value>
        string PlaceholderText { get; set; }

        /// <summary>
        /// Gets or sets a validation mechanism for the control.
        /// </summary>
        /// <value>The validation.</value>
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        ValidatorDefinition ValidatorDefinition { get; set; }

        /// <summary>
        /// Gets the meta field.
        /// </summary>
        /// <param name="formFieldControl">The form field control.</param>
        /// <returns></returns>
        IMetaField GetMetaField(IFormFieldControl formFieldControl);

        /// <summary>
        /// Determines whether this instance is valid.
        /// </summary>
        /// <returns></returns>
        bool IsValid();
    }
}
