# Inverda


Unity settings for using GitHub

  Edit -> Project settings -> Editor -> Version Control = Visible Meta Files
  
  Edit -> Project Settings -> Editor -> Asset Serialization = Force Text
  
Using Git hub

  install git -> https://git-scm.com/download/win
  
  Create a new folder (inverda), This is your game project folder.
  
  in the folder open git Bash.
  
  Init the folder (git init)
  
  add the repo to the folder. (git remote add inverda https://github.com/Corbris/Inverda.git)
  
  
Pulling new code from github

  git pull inverda <branch name>
  
  
Pushing your code to gitHub branch

  git add . (adds all changes to staging)
  
  git commit -m "Some message about your chnges" (do this for all major changes)
  
  git pull inverda master (MUST DO THIS BEFORE YOu ULOAD TO GIT)
  
  git push inverda <branch name> (typicaly when you finish your feature)
  
Creating Branches

  When woring on a new feature you need to make a new branch. The "master" branch is the working game, and should never be used to push changes to. 
  
  Make a new branch for your feature. (git branch <branch name>)
  
  go into that branch (git checkout <branch>)
  
  All changes will now be made to that branch.
  
  
Merging branches with master.

  After working on a feature and you want it to be added to the master branch. You need to make a pull request. A pull request will open a notification that you wish to merge your branch into master. It will allow for all the team members to look at that feature and determin if there will be conflicts with the merge.
  
  
any questions please ask me. As long as you never push to master noting can get thaat messed up....
