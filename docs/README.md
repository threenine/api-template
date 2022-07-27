# Editing Documentation

To be able to edit the documentation and to get it running locally, you will need to install the following dependencies:

## Ubuntu

```shell
sudo apt-get install ruby-full build-essential zlib1g-dev
```

Then changed into the`docs` directory

```shell
cd docs
```

Then execute bundle install to install all Gems used within the directory

```shell
bundle install 
```

You can then execute the following
```shell
bundle exec jekyll serve
```