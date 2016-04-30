#ifndef �tanOperator_h__
#define �tanOperator_h__

#include "Base/UnaryOperatorBase.h"


class CtanOperator : public UnaryOperatorBase
{
public:
	ExpressionBytes GetBytes(ValueType *operand, ValueType *result) const override
	{
		Assembler assembler;
		assembler.Load(operand)
			.Tan().Div()
			.Store(result);

		return assembler.GetData();
	}

	const char * OperatorName() const override
	{
		return "ctan";
	}

	OperatorPriority Priority() const override
	{
		return OperatorBase::Highest;
	}
};

#endif // �tanOperator_h__
