mergeInto(LibraryManager.library, {

	BlockHotkeys: function ()
	{
		document.body.addEventListener('keydown', event => {
			if (event.ctrlKey && 'cvxspwuaz'.indexOf(event.key) !== -1) {
				event.preventDefault()
			}
		})
	},

});