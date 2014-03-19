﻿// This file is part of HangFire.
// Copyright © 2013-2014 Sergey Odinokov.
// 
// HangFire is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// HangFire is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with HangFire.  If not, see <http://www.gnu.org/licenses/>.

using System;

namespace HangFire.Client.Filters
{
    /// <summary>
    /// Provides the context for the <see cref="IClientFilter.OnCreated"/> 
    /// method of the <see cref="IClientFilter"/> interface.
    /// </summary>
    public class CreatedContext : CreateContext
    {
        internal CreatedContext(
            CreateContext context, 
            bool canceled, 
            Exception exception)
            : base(context)
        {
            Canceled = canceled;
            Exception = exception;
        }

        /// <summary>
        /// Gets an exception that occurred during the creation of the job.
        /// </summary>
        public Exception Exception { get; private set; }

        /// <summary>
        /// Gets a value that indicates that this <see cref="CreatedContext"/>
        /// object was canceled.
        /// </summary>
        public bool Canceled { get; private set; }

        /// <summary>
        /// Gets or sets a value that indicates that this <see cref="CreatedContext"/>
        /// object handles an exception occurred during the creation of the job.
        /// </summary>
        public bool ExceptionHandled { get; set; }
    }
}