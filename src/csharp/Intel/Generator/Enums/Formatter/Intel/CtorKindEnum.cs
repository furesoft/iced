/*
Copyright (C) 2018-2019 de4dot@gmail.com

Permission is hereby granted, free of charge, to any person obtaining
a copy of this software and associated documentation files (the
"Software"), to deal in the Software without restriction, including
without limitation the rights to use, copy, modify, merge, publish,
distribute, sublicense, and/or sell copies of the Software, and to
permit persons to whom the Software is furnished to do so, subject to
the following conditions:

The above copyright notice and this permission notice shall be
included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY
CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE
SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

using System.Linq;

namespace Generator.Enums.Formatter.Intel {
	enum CtorKind {
		Previous,
		Normal_1,
		Normal_2,
		asz,
		AX,
		AY,
		bcst,
		bnd_1,
		bnd_2,
		DeclareData,
		fpu_ST_STi,
		fpu_STi_ST,
		imul,
		k1,
		k2,
		maskmovq,
		memsize,
		movabs,
		nop,
		os2,
		os3,
		os_bnd,
		CC_1,
		CC_2,
		CC_3,
		os_jcc_a_1,
		os_jcc_a_2,
		os_jcc_a_3,
		os_jcc_b_1,
		os_jcc_b_2,
		os_jcc_b_3,
		os_loopcc,
		os_loop,
		os_mem,
		pclmulqdq,
		pops,
		reg,
		Reg16,
		ST_STi,
		ST1_2,
		ST1_3,
		ST2,
		STi_ST,
		xbegin,
		YA,
		invlpga,
	}

	static class CtorKindEnum {
		const string? documentation = null;

		static EnumValue[] GetValues() =>
			typeof(CtorKind).GetFields().Where(a => a.IsLiteral).Select(a => new EnumValue((uint)(CtorKind)a.GetValue(null)!, a.Name, CommentAttribute.GetDocumentation(a))).ToArray();

		public static readonly EnumType Instance = new EnumType(nameof(CtorKind), TypeIds.IntelCtorKind, documentation, GetValues(), EnumTypeFlags.None);
	}
}
