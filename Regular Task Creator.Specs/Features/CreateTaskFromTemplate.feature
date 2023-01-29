Feature: Create Task From Template

#M,T,W,Th,F,St,S
#Monday = M, Tuesday = T, Wednesday = W, Thursday = Th, Friday = F, Saturday = St, Sunday = S
#Пример: при указании M задача будет создаваться на начало понедельника

# При создании задачи используется заглушка, на самом деле константа
# Работает автономно без участия пользователя
Scenario: Создание задачи из шаблона
	Given список шаблонов из
		| Name          | Recreate Days | Description               |
		| Помыть посуду | M,T,Th        | Используй моющее средство |
	When день совпадает
	Then создать задачу из шаблона
	And количество задач в списке 2
		
