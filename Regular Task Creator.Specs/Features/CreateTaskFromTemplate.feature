Feature: Create Task From Template

#M,T,W,Th,F,St,S
#Monday = M, Tuesday = T, Wednesday = W, Thursday = Th, Friday = F, Saturday = St, Sunday = S
#Пример: при указании M задача будет создаваться на начало понедельника

# При создании задачи используется заглушка, на самом деле константа
# Работает автономно без участия пользователя
Scenario: Создание задачи из шаблона
	Given семья из 
		| Name | Phone        | Email             | Adult |
		| Папа | +79180000001 | father@family.com | true  |
		| Сын  | +79180000002 | son@family.com    | false |
	And список шаблонов из
		| Id | Name          | Recreate Days | Description               |
		| 1  | Помыть посуду | M,T,Th        | Используй моющее средство |
	When наступил M
	Then создать задачу из шаблона с Id 1
		
