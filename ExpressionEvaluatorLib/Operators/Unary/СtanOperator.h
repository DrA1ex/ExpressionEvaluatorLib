#ifndef �tanOperator_h__
#define �tanOperator_h__

#include "Base\UnaryOperatorBase.h"


class CtanOperator : public UnaryOperatorBase
{
public:
	ExpressionBytes GetBytes(ValueType *operand, ValueType *result) const
	{
		Assembler assembler;
		assembler.Load(operand)
			.Tan().Div()
			.Store(result);

		return assembler.GetData();
	}

	virtual const char * OperatorName() const
	{
		return "ctan";
	}

	virtual OperatorPriority Priority() const
	{
		return OperatorBase::Highest;
	}
};

#endif // �tanOperator_h__
