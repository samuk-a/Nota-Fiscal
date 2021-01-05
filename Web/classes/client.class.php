<?php


class Client
{
    public $id;
    public $cpf;
    public $nome;
    public $razSoc;
    public $end;
    public $bairro;
    public $cidade;
    public $cep;
    public $fone;
    public $isNew;

    public function __construct($id = 0, $cpf = '', $nome = '', $razSoc = '', $end = '', $bairro = '', $cidade = '', $cep = '', $fone = '', $isNew = true) {
        $this->id = $id;
        $this->cpf = $cpf;
        $this->nome = $nome;
        $this->razSoc = $razSoc;
        $this->end = $end;
        $this->bairro = $bairro;
        $this->cidade = $cidade;
        $this->cep = $cep;
        $this->fone = $fone;
        $this->isNew = $isNew;
    }

    
}