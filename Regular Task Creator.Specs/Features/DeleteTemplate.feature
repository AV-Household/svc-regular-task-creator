Feature: Delete Template

#M,T,W,Th,F,St,S
#Monday = M, Tuesday = T, Wednesday = W, Thursday = Th, Friday = F, Saturday = St, Sunday = S
#Пример: при указании M задача будет создаваться на начало понедельника

Scenario: Родитель может удалить шаблон
	Given семья из 
		| Name | Phone        | Email             | Adult |
		| Папа | +79180000001 | father@family.com | true  |
		| Сын  | +79180000002 | son@family.com    | false |
	And список шаблонов из
		| Id | Name          | Recreate Days | Description               |
		| 1  | Помыть посуду | M,T,Th        | Используй моющее средство |
	And в систему вошел Папа
	When пользователь удаляет шаблон с Id 1
	Then количество шаблонов в списке 0

Scenario: Ребенок не может удалить шаблон
	Given семья из 
		| Name | Phone        | Email             | Adult |
		| Папа | +79180000001 | father@family.com | true  |
		| Сын  | +79180000002 | son@family.com    | false |
	And список шаблонов из
		| Id | Name          | Recreate Days | Description               |
		| 1  | Помыть посуду | M,T,Th        | Используй моющее средство |
	And в систему вошел Сын
	When пользователь удаляет шаблон с Id 1
	Then количество шаблонов в списке 1

Scenario: Родитель не может удалить несуществующий шаблон
	Given семья из 
		| Name | Phone        | Email             | Adult |
		| Папа | +79180000001 | father@family.com | true  |
		| Сын  | +79180000002 | son@family.com    | false |
	And список шаблонов из
		| Id | Name          | Recreate Days | Description               |
		| 1  | Помыть посуду | M,T,Th        | Используй моющее средство |
	And в систему вошел Папа
	When пользователь удаляет шаблон с Id 2
	Then количество шаблонов в списке 1
