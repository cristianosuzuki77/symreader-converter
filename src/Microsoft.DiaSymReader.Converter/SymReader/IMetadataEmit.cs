﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

#pragma warning disable 436 // SuppressUnmanagedCodeSecurityAttribute defined in source and mscorlib 

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.DiaSymReader
{
    [ComImport]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [Guid("BA3FEE4C-ECB9-4e41-83B7-183FA41CD859")]
    [SuppressUnmanagedCodeSecurity]
    internal unsafe interface IMetadataEmit
    {
        // SymWriter doesn't use any methods from this interface except for GetTokenFromSig, which is only called when 
        // DefineLocalVariable(2) and DefineConstant(2) don't specify signature token, or the token is nil.

        void __SetModuleProps();
        void __Save();
        void __SaveToStream();
        uint __GetSaveSize();
        uint __DefineTypeDef();
        uint __DefineNestedType();
        void __SetHandler();
        uint __DefineMethod();
        void __DefineMethodImpl();
        uint __DefineTypeRefByName();

        uint __DefineImportType();
        uint __DefineMemberRef();
        uint __DefineImportMember();
        uint __DefineEvent();
        void __SetClassLayout();

        void __DeleteClassLayout();
        void __SetFieldMarshal();
        void __DeleteFieldMarshal();
        uint __DefinePermissionSet();
        void __SetRVA();

        int GetTokenFromSig(byte* voidPointerSig, int byteCountSig);

        uint __DefineModuleRef();
        void __SetParent();
        uint __GetTokenFromTypeSpec();
        void __SaveToMemory();
        uint __DefineUserString();
        void __DeleteToken();
        void __SetMethodProps();
        void __SetTypeDefProps();
        void __SetEventProps();
        uint __SetPermissionSetProps();
        void __DefinePinvokeMap();
        void __SetPinvokeMap();
        void __DeletePinvokeMap();
        uint __DefineCustomAttribute();
        void __SetCustomAttributeValue();
        uint __DefineField();
        uint __DefineProperty();
        uint __DefineParam();
        void __SetFieldProps();
        void __SetPropertyProps();
        void __SetParamProps();
        uint __DefineSecurityAttributeSet();
        void __ApplyEditAndContinue();
        uint __TranslateSigWithScope();
        void __SetMethodImplFlags();
        void __SetFieldRVA();
        void __Merge();
        void __MergeEnd();
    }
}
