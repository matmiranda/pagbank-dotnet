﻿using System.ComponentModel;

namespace PagBank.Enums
{
    public enum BaseUrl
    {
        [Description("https://sandbox.api.pagseguro.com")]
        Sandbox,

        [Description("https://secure.sandbox.api.pagseguro.com")]
        SandboxSecure,

        [Description("https://sandbox.api.assinaturas.pagseguro.com")]
        SandboxSignature,

        [Description("https://api.pagseguro.com")]
        Production,

        [Description("https://secure.api.pagseguro.com")]
        ProductionSecure,

        [Description("https://api.assinaturas.pagseguro.com")]
        ProductionSignature

    }
}
