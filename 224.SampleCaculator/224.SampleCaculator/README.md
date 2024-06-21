224.基本计算器
执行用时 :424 ms, 在所有 csharp 提交中击败了8.33%的用户
内存消耗 :37.3 MB, 在所有 csharp 提交中击败了9.52%的用户

基本思路：
	一.将字符串拆解成数字、括号、符号的列表（list）
	二.两个栈，一个存数，一个存操作符
	三.利用栈去括号
		for(var item in list)
		{
			if(item 是左括号)
			{
				设置"不需要计算"标记
			}
			else if(item 是右括号)
			{
				设置"需要计算"标记
			}
			else if (item 是符号)
			{
				存到符号栈
			}
			else if (item 是数字)
			{
				if(需要计算)
				{
					数字栈弹出数字、符号栈弹出符号、item 进行计算
					结果push到数字栈中
				}
				else // 不需要计算
				{
					item Push到数字栈中
				}
			}
		}

PS：这类题有个通用的算法：转换成逆波兰表达式，复习的时候尝试下。