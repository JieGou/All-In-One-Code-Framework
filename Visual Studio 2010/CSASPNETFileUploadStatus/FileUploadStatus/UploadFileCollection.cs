﻿/****************************** Module Header ******************************\
* Module Name:    UploadFileCollection.cs
* Project:        CSASPNETFileUploadStatus
* Copyright (c) Microsoft Corporation
*
* The project illustrates how to display the upload status and progress without
* a third part component like ActiveX control, Flash or Silverlight.
* 
* This is a class for a collection of the uploading files in the request entity. 
* 
* This source is subject to the Microsoft Public License.
* See http://www.microsoft.com/opensource/licenses.mspx#Ms-PL.
* All other rights reserved.
*
\*****************************************************************************/

using System.Collections.Generic;
namespace CSASPNETFileUploadStatus
{
    public class UploadFileCollection :
        List<UploadFile>
    {
    }
}
