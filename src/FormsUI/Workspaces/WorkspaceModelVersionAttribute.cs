// -----------------------------------------------------------------------------------
//   _____ _      _____    _____ __  __ _____   ____  _____ _______
//  / ____| |    |  __ \  |_   _|  \/  |  __ \ / __ \|  __ \__   __|
// | (___ | |    | |  | |   | | | \  / | |__) | |  | | |__) | | |
//  \___ \| |    | |  | |   | | | |\/| |  ___/| |  | |  _  /  | |
//  ____) | |____| |__| |  _| |_| |  | | |    | |__| | | \ \  | |
// |_____/|______|_____/  |_____|_|  |_|_|     \____/|_|  \_\ |_|
//
//   Copyright © 2016-2018 PerkinElmer Inc.,
//   940 Winter Street, Waltham, MA 02451.
//   All rights reserved.
//   This software is the confidential and proprietary information
//   of PerkinElmer Inc. ("Confidential Information"). You shall not
//   disclose such Confidential Information and may not use it in any way,
//   absent an express written license agreement between you and PerkinElmer Inc.
//   that authorizes such use.
// -----------------------------------------------------------------------------------

using System;

namespace FormsUI.Workspaces
{
    /// <summary>
    /// Represents the version of the decorated workspace model.
    /// </summary>
    /// <seealso cref="System.Attribute" />
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class WorkspaceModelVersionAttribute : Attribute
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceModelVersionAttribute"/> class.
        /// </summary>
        /// <param name="major">The major version of the workspace model.</param>
        /// <param name="minor">The minor version of the workspace model.</param>
        public WorkspaceModelVersionAttribute(int major, int minor)
        {
            Version = new WorkspaceModelVersion(major, minor);
        }

        #endregion Public Constructors

        #region Public Properties

        /// <summary>
        /// Gets the version of the workspace model.
        /// </summary>
        /// <value>
        /// The version.
        /// </value>
        public WorkspaceModelVersion Version { get; }

        #endregion Public Properties
    }
}