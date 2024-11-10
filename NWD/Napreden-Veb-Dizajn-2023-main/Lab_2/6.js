// Write the function sort_by_num_calls

// const sort_by_num_calls = function(){} ;

function sort_by_num_calls(functions) { // vaa funkcija dobiva funkcii 
    
	function countCalls(func) {	 ovaa funkcija broe kolku kalovi ima funkcijata pratena na nea
        	let calls = 0;
        	while (typeof func === 'function') { ako dobienata func e funkcija 
          	  func = func(); u func povikaj ja func()
          	  calls++; i kazi deka ima class
        	}/ ke se povtoruva se dodeka imame func u func koa ja dodluvame na func
       		return calls;
	}
			
    return functions.sort((func1, func2) => countCalls(func1) - countCalls(func2));
	/voa go koristeme za sortiranje u rastecki redosled
}