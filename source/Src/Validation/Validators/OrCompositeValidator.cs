﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Validation.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Validation.Properties;
using System.Globalization;

namespace Microsoft.Practices.EnterpriseLibrary.Validation.Validators
{
    /// <summary>
    /// Aggregates a set of <see cref="Validator"/> instances, performing validation by allowing each validator to perform its own.
    /// </summary>
    /// <remarks>
    /// Validation results are logged only if all composed validators log results.
    /// </remarks>
#if NET471
    [ConfigurationElementType(typeof(OrCompositeValidatorData))]
#endif
    public class OrCompositeValidator : Validator
    {
        private IEnumerable<Validator> validators;

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="OrCompositeValidator"/> class.</para>
        /// </summary>
        /// <param name="validators">The validators to be composed by the created instance.</param>
        public OrCompositeValidator(params Validator[] validators)
            : this(null, validators)
        { }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="OrCompositeValidator"/> class.</para>
        /// </summary>
        /// <param name="messageTemplate"></param>
        /// <param name="validators">The validators to be composed by the created instance.</param>
        public OrCompositeValidator(string messageTemplate, params Validator[] validators)
            : base(messageTemplate, null)
        {
            this.validators = validators;
        }

        /// <summary>
        /// Implements the validation logic for the receiver, invoking validation on the composed validators.
        /// </summary>
        /// <param name="objectToValidate">The object to validate.</param>
        /// <param name="currentTarget">The object on the behalf of which the validation is performed.</param>
        /// <param name="key">The key that identifies the source of <paramref name="objectToValidate"/>.</param>
        /// <param name="validationResults">The validation results to which the outcome of the validation should be stored.</param>
        /// <remarks>
        /// The results the generated by the composed validators are logged to <paramref name="validationResults"/>
        /// only if all the validators generate results.
        /// </remarks>
        public override void DoValidate(object objectToValidate,
            object currentTarget,
            string key,
            ValidationResults validationResults)
        {
            List<ValidationResult> childrenValidationResults = new List<ValidationResult>();

            foreach (Validator validator in this.validators)
            {
                ValidationResults childValidationResults = new ValidationResults();
                validator.DoValidate(objectToValidate, currentTarget, key, childValidationResults);
                if (childValidationResults.IsValid)
                {
                    // no need to query the rest of the validators
                    return;
                }

                childrenValidationResults.AddRange(childValidationResults);
            }

            LogValidationResult(validationResults,
                GetMessage(objectToValidate, key),
                currentTarget, 
                key,
                childrenValidationResults);
        }

        /// <summary>
        /// Gets the message template to use when logging results no message is supplied.
        /// </summary>
        /// <remarks>
        /// This validator does not log messages of its own.
        /// </remarks>
        protected override string DefaultMessageTemplate
        {
            get { return Resources.OrCompositeValidatorDefaultMessageTemplate; }
        }

        /// <summary>
        /// Child validators that are being Or'red together.
        /// </summary>
        public IEnumerable<Validator> Validators
        {
            get
            {
                return this.validators;
            }
        }
    }
}
