## Unity settings for using GitHub

	
	Edit -> Project settings -> Editor -> Version Control = Visible Meta Files
	Edit -> Project Settings -> Editor -> Asset Serialization = Force Text

## Using Git hub

	install git ->     [https://git-scm.com/download/win](https://git-scm.com/download/win)
	Create a new folder (inverda), This is your game project folder.
	in the folder open git Bash.
	Init the folder (git init)
	add the repo to the folder. (git remote add inverda     [https://github.com/Corbris/Inverda.git](https://github.com/Corbris/Inverda.git))


## your git flow for a new feature
	### make a new branch
	git pull inverda master    -get latest master
	git branch <feature_name>    -make a new branch for your feature 
	git checkout <feature_name>    -move into the branch
	
	###commiting/saving changes 
	git add <fileName>    -move changed file into staging (git add .) for all files
	git commit -m "message about the change"     -commit changes with a message 
	git push inverda <feature_name>     -push your commits to github. Only needed if onther people are working on this.
	
	### merge with master when finished with feature. 
	git checkout master    -move to master
	git pull inverda master    -get latest master branch
	git checkout <feature_name>    -move back into your feature branch
	git merge master    -merge your branch with master. This can have merge conflicts that you need to fix. (not sure how this works in Unity... if you need help ask.)
	
	### fixing a merge
	git add .     -fix the merge conflicst add them to staging
	git commit -m "fixing merge conflicts"    -commit changes
	
	### branch and master were merged.
	git push inverda <feature_name>     -push your local branch to github.com
	
	### make a pull request on github.com
	Make a PR at - https://github.com/Corbris/Inverda/compare
	The branch should be the same as master with the new feature you were working on. 
	The PR should tell you that it can merge with no conflicts.
	Get others to review your PR, and if everyone is good with the changes we can merge it.
	
	
## Pulling new code from github

	git pull inverda <branch name>

## Pushing your code to gitHub branch

	git add . (adds all changes to staging)
	git commit -m "Some message about your chnges" (do this for all major changes)
	git pull inverda master (MUST DO THIS BEFORE YOu ULOAD TO GIT)
	git push inverda (typicaly when you finish your feature)

## Creating Branches

	When working on a new feature you need to make a new branch. The "master" branch is the working game, and should never be used to push changes to.
	Make a new branch for your feature. (git branch )
	go into that branch (git checkout )
	All changes will now be made to that branch.

## Merging branches with master.

After working on a feature and you want it to be added to the master branch. You need to make a pull request. A pull request will open a notification that you wish to merge your branch into master. It will allow for all the team members to look at that feature and determine if there will be conflicts with the merge.

## **any questions please ask me. As long as you never push to master noting can get that messed up....**

