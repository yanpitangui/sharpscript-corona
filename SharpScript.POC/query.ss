Brazilian cities with death count > 0

{{ cities |> where => !it.IsRepeated && it.LastAvailableDeaths > 0
		|> groupBy => it.State
		|> map => { State: it.Key, Cities: it} |> to => groups
		}}

```code
#each groups}}
 `State: ${State}, Cities affected: ${Cities.count()}, Death Count: ${Cities.sum(x=> x.LastAvailableDeaths)}`
/each

```
