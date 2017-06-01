// ***********************************************************************
// Assembly         : ACBr.Net.Sat
// Author           : RFTD
// Created          : 05-30-2017
//
// Last Modified By : RFTD
// Last Modified On : 05-30-2017
// ***********************************************************************
// <copyright file="MFeIntegradorResp.cs" company="ACBr.Net">
//		        		   The MIT License (MIT)
//	     		    Copyright (c) 2016 Grupo ACBr.Net
//
//	 Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the "Software"),
// to deal in the Software without restriction, including without limitation
// the rights to use, copy, modify, merge, publish, distribute, sublicense,
// and/or sell copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following conditions:
//	 The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//	 THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
// IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
// DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
// ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
// DEALINGS IN THE SOFTWARE.
// </copyright>
// <summary></summary>
// ***********************************************************************

using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Common;
using ACBr.Net.DFe.Core.Serializer;

namespace ACBr.Net.Sat
{
	[DFeRoot("Integrador")]
	public sealed class MFeIntegradorResp : DFeDocument<MFeIntegradorResp>

	{
		#region Constructors

		public MFeIntegradorResp()
		{
			Identificador = new MFeIdentificador();
			IntegradorResposta = new MFeIntegradorResposta();
            Retorno = string.Empty;
		}

		#endregion Constructors

		#region Properties

		[DFeElement("Identificador", Ocorrencia = Ocorrencia.Obrigatoria)]
		public MFeIdentificador Identificador { get; set; }

		[DFeElement("IntegradorResposta", Ocorrencia = Ocorrencia.Obrigatoria)]
		public MFeIntegradorResposta IntegradorResposta { get; set; }

		[DFeElement(TipoCampo.Str, "retorno")]
		public string Retorno { get; set; }

		#endregion Properties
	}
}