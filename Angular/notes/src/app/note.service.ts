import { Injectable } from '@angular/core';
import { Note } from './note';
import { addDoc, doc, deleteDoc, Firestore, updateDoc } from 'firebase/firestore';
import { collection } from 'firebase/firestore';
import { Observable } from 'rxjs';
import { collectionData } from '@angular/fire/firestore';

@Injectable({
  providedIn: 'root'
})
export class NoteService {

  constructor(private fs:Firestore) { }

  addNote(note: Note){
    note.id = doc(collection(this.fs, 'id')).id
    return addDoc(collection(this.fs, 'Notes'),note)
  }

  getNotes():Observable<Note[]>{
    let notesRef = collection(this.fs, 'Notes')
    return collectionData(notesRef, {idField: 'id'}) as Observable<Note[]>
  }  

  deleteDoc(note: Note){
    let docRef = doc(collection(this.fs, `Notes/${note.id}`));

    return deleteDoc(docRef)
  }

  updateNote(note: Note, notes: any){
    let docRef = doc(this.fs, `Notes/${note.id}`);
    return updateDoc(docRef, notes)
  } 




}
